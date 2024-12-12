using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVP_Projekat.OsnovneKlase;

namespace TVP_Projekat.FormeZaUnos
{
    public partial class DodajRezervaciju : Form
    {
        string idZaAzuriranje = "";
        string slektovanIzlet = "";
        string sleketovanKorisnik = "";

        Korisnik ulogovaniKorisnik = new Korisnik();
        public enum tipForme { admin, client };
        public tipForme tip;
        public DodajRezervaciju()//Konstruktor kada se pristupa pomocu admina
        {
            InitializeComponent();
        }

        public DodajRezervaciju(string id, int brRezervisanihMesta, string idKorisnika, string idIzleta)
        {//Konstruktor za izmenu - admin
            InitializeComponent();

            brojMesta_txt.Text = brRezervisanihMesta.ToString();
            idZaAzuriranje = id;

            slektovanIzlet = idIzleta;
            sleketovanKorisnik = idKorisnika;

        }
        public DodajRezervaciju(Korisnik ulogovaniKor)//Konstruktor kada se pristupa pomocu klijenta
        {
            InitializeComponent();
            this.ulogovaniKorisnik = ulogovaniKor;
        }

        public DodajRezervaciju(Korisnik ulogovaniKor, string id, int brRezervisanihMesta, string idKorisnika, string idIzleta)
        {//Konstruktor za izmenu kada se pristupa pomocu klijenta
            InitializeComponent();

            this.ulogovaniKorisnik = ulogovaniKor;

            brojMesta_txt.Text = brRezervisanihMesta.ToString();
            idZaAzuriranje = id;

            slektovanIzlet = idIzleta;
            sleketovanKorisnik = idKorisnika;

        }

        private void DodajRezervaciju_Load(object sender, EventArgs e)
        {
            Provere.DodajProveruUnosa(Controls);

            brojMesta_txt.Focus();
            List<Izlet> izleti = GlobalnaLista<Izlet>.Instanca().Vrati();

            korisnici_dgw.DataSource = GlobalnaLista<Korisnik>.Instanca().Vrati();
            izleti_dgw.DataSource = izleti;

            izleti_dgw.Columns["id"].Visible = false;
            izleti_dgw.Columns["zastareo"].Visible = false;

            korisnici_dgw.Columns["id"].Visible = false;

            //Utils.SakrijZastareleLinije<Izlet>(izleti_dgw);


            if (this.tip == tipForme.client)
            {
                izleti_dgw.Columns["id"].Visible = false;
                korisnici_dgw.Visible = false;
                korisnik_lbl.Visible = false;
                filterMesto_lbl.Visible = true;
                filterMesto_txt.Visible = true;
            }
            if (this.tip == tipForme.admin)
            {
                korisnici_dgw.Visible = true;
                korisnik_lbl.Visible = true;
                filterMesto_lbl.Visible = false;
                filterMesto_txt.Visible = false;
            }


        }

        private void kreirajRezervaciju_btn_Click(object sender, EventArgs e)
        {
            if (Provere.DaLiPostojeGreske(Controls))
                return;

            int brRezervisanihMesta = 0;

            if (brojMesta_txt.Text != "")
                brRezervisanihMesta = int.Parse(brojMesta_txt.Text);

            //if (brRezervisanihMesta<=0) {
            //    MessageBox.Show("Uneli ste broj manji od nule!");
            //    return;
            //}

            List<Izlet> selektovaniIzleti = Administrator.VratiSelektovaneRedove<Izlet>(
            viseredovnaSelekcija: false,
            dataGrid: izleti_dgw,
            brSelektovanih: out int brSelektovanihIzleta
            );

            if (selektovaniIzleti == null || selektovaniIzleti.Count == 0)
                return;

            Izlet izlet = selektovaniIzleti[0];

            if (brRezervisanihMesta > izlet.ukupnoMesta)
            {
                MessageBox.Show("Nema toliko slobodnih mesta!");
                brojMesta_txt.Clear();
                return;
            }

            Rezervacija staraRez = GlobalnaLista<Rezervacija>.Instanca().VratiPoId(idZaAzuriranje);
            Korisnik kor;

            //Proveravamo da li smo ovoj formi pristupili kao klijent ili admin
            if (ulogovaniKorisnik.korisnickoIme == "" && ulogovaniKorisnik.lozinka == "")
            {
                List<Korisnik> selektovaniKorisnici = Administrator.VratiSelektovaneRedove<Korisnik>(
                  viseredovnaSelekcija: false,
                  dataGrid: korisnici_dgw,
                  brSelektovanih: out int brSelektovanihKorisnika
                  );

                if (selektovaniKorisnici.Count == 0 || selektovaniKorisnici == null)
                    return;

                kor = selektovaniKorisnici[0];
            }
            else
            {
                kor = ulogovaniKorisnik;
            }

            //Proveravamo da li postoji preklapanje datuma nove rezervacije i ostalih rezervacija koje korisnik ima
            foreach (IzletRezervacija rez in GlobalnaLista<IzletRezervacija>.Instanca().Vrati())
            {
                if (rez.idKorisnika == kor.id)
                {

                    //if (rez.zastareo == true) {//Ako je rezervacija zastarela onda nju ne proveramo
                    //continue;

                    //}
                    if (staraRez != null)
                    {//Ako se rezervacija azurira onda pri proveri preklapanja njen datum zanemarimo
                        if (rez.id == staraRez.id)
                        {
                            continue;
                        }
                    }

                    Izlet vecRezervisanIzlet = GlobalnaLista<Izlet>.Instanca().VratiPoId(rez.idIzleta);

                    if (izlet.preklapanjeIzleta(vecRezervisanIzlet))
                    {
                        MessageBox.Show("Nije moguce kreirati rezervaciju korisniku: " + kor.korisnickoIme
                                + " jer postoji preklapanje datuma u rezervacijama!"
                                );
                        return;
                    }


                }

            }

            Rezervacija rezervacija;
            IzletRezervacija izlRez;
            if (idZaAzuriranje != "" && staraRez != null)
            {
                //staraRez.oslobodiRezervaciju();
                GlobalnaLista<Rezervacija>.Instanca().Ukloni(staraRez);
                GlobalnaLista<IzletRezervacija>.Instanca().Ukloni(GlobalnaLista<IzletRezervacija>.Instanca().VratiPoId(staraRez.id));


                rezervacija = new Rezervacija(idZaAzuriranje, kor.id, izlet.id, brRezervisanihMesta);
                GlobalnaLista<Rezervacija>.Instanca().Dodaj(rezervacija);

                izlRez = new IzletRezervacija(kor.id, false, false, rezervacija.id, izlet.id, izlet.datum, izlet.drzava, izlet.mesto, izlet.brojDana, rezervacija.ukupnaCena, rezervacija.brRezervisanihMesta, rezervacija.datumKreacijeRezervacije);
                GlobalnaLista<IzletRezervacija>.Instanca().Dodaj(izlRez);

                GlobalnaLista<Izlet>.Instanca().OsveziFajl();
                GlobalnaLista<IzletRezervacija>.Instanca().OsveziFajl();


                idZaAzuriranje = "";
                MessageBox.Show("Uspesno izmenjena rezervacija!");

            }
            else
            {
                rezervacija = new Rezervacija(kor.id, izlet.id, brRezervisanihMesta);
                rezervacija.kreirajRezervaciju();

                izlRez = new IzletRezervacija(kor.id, false, false, rezervacija.id, izlet.id, izlet.datum, izlet.drzava, izlet.mesto, izlet.brojDana, rezervacija.ukupnaCena, rezervacija.brRezervisanihMesta, rezervacija.datumKreacijeRezervacije);
                GlobalnaLista<IzletRezervacija>.Instanca().Dodaj(izlRez);

                GlobalnaLista<Izlet>.Instanca().OsveziFajl();
                GlobalnaLista<IzletRezervacija>.Instanca().OsveziFajl();

            }

            if (ulogovaniKorisnik.korisnickoIme == "" && ulogovaniKorisnik.lozinka == "")
                MessageBox.Show("Uspesno kreirana rezervacija za korisnika: " + kor.korisnickoIme);
            else
                MessageBox.Show("Uspesno kreirana rezervacija!");


            this.Close();

        }

        private void filterMesto_txt_TextChanged(object sender, EventArgs e)
        {
            if (this.tip != tipForme.client)
                return;

            string mesto = filterMesto_txt.Text.Trim().ToLower();

            List<Izlet> izleti = GlobalnaLista<Izlet>.Instanca().Vrati();
            List<Izlet> izfiltriraniIzleti = new List<Izlet>();

            foreach (Izlet izlet in izleti)
            {
                if (izlet.mesto.ToLower().StartsWith(mesto))
                {
                    izfiltriraniIzleti.Add(izlet);
                }
            }
            izleti_dgw.DataSource = izfiltriraniIzleti;
        }

        private void izleti_dgw_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (slektovanIzlet != "")
            {
                Utils.SelektujRedUGrid<Izlet>(GlobalnaLista<Izlet>.Instanca().VratiPoId(slektovanIzlet), izleti_dgw);

            }
            Utils.SakrijZastareleLinije<Izlet>(izleti_dgw);

        }

        private void korisnici_dgw_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (sleketovanKorisnik!= "")
            {
                Utils.SelektujRedUGrid<Korisnik>(GlobalnaLista<Korisnik>.Instanca().VratiPoId(sleketovanKorisnik), korisnici_dgw);


            }
        }
    }
}
