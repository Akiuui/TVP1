using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVP_Projekat.FormeZaUnos;
using TVP_Projekat.OsnovneKlase;

namespace TVP_Projekat
{
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }
        private bool onlyOnce = false;
        private void Administrator_Load(object sender, EventArgs e)
        {
            korisnici_dgw.DataSource = GlobalnaLista<Korisnik>.Instanca().Vrati();
            izleti_dgw.DataSource = GlobalnaLista<Izlet>.Instanca().Vrati();
            Utils.SakrijZastareleLinije<Izlet>(izleti_dgw);

            rezervacije_dgw.DataSource = GlobalnaLista<IzletRezervacija>.Instanca().Vrati();

            //List<IzletRezervacija> izlRez = Utils.KreiranjeIzletRezervacija();
            //rezervacije_dgw.DataSource = izlRez;
            //rezervacije_dgw.ReadOnly = true;

            //izleti_dgw.Columns["id"].Visible = false;
            ////izleti_dgw.Columns["zastareo"].Visible = false;
            //korisnici_dgw.Columns["id"].Visible = false;
            //rezervacije_dgw.Columns["id"].Visible = false;
            //rezervacije_dgw.Columns["idIzleta"].Visible = false;
            //rezervacije_dgw.Columns["idKorisnika"].Visible = false;
            //rezervacije_dgw.Columns["zastareo"].Visible = false;
            //rezervacije_dgw.Columns["zastareoIzlet"].Visible = false;
            //rezervacije_dgw.Columns["zastareoRez"].Visible = false;


            GlobalnaLista<Korisnik>.Instanca().dogodilaSePromena += Administrator_dogodilaSePromena;
            GlobalnaLista<Izlet>.Instanca().dogodilaSePromena += Administrator_dogodilaSePromena;
            GlobalnaLista<Rezervacija>.Instanca().dogodilaSePromena += Administrator_dogodilaSePromena;

            Provere.DodajProveruUnosa(Controls);

        }

        private void Administrator_dogodilaSePromena(object? sender, EventArgs e)
        {
            korisnici_dgw.DataSource = GlobalnaLista<Korisnik>.Instanca().Vrati();
            izleti_dgw.DataSource = GlobalnaLista<Izlet>.Instanca().Vrati();


            //foreach (IzletRezervacija rez in GlobalnaLista<IzletRezervacija>.Instanca().Vrati())
            //    MessageBox.Show(rez.ToString());

            rezervacije_dgw.DataSource = GlobalnaLista<IzletRezervacija>.Instanca().Vrati();


            //List<IzletRezervacija> izlRez = Utils.KreiranjeIzletRezervacija();
            //rezervacije_dgw.DataSource = izlRez;

            //foreach (DataGridViewRow row in rezervacije_dgw.Rows)
            //{

            //    var klijent = (from sve in izlRez
            //                   where (string)sve.idKorisnika == (string)row.Cells["idKorisnika"].Value
            //                   select sve.idKorisnika).FirstOrDefault();

            //    Korisnik kor = GlobalnaLista<Korisnik>.Instanca().VratiPoId(klijent);
            //    string ime = kor.ime + " " + kor.prezime;
            //    row.Cells["Klijent"].Value = ime;
            //}

            //Utils.PunjenjeIzletRezervacijaDGW(Utils.KreiranjeIzletRezervacija(), rezervacije_dgw);
            //rezervacije_dgw.DataSource = Utils.KreiranjeIzletRezervacija();
        }

        //Dodavanje----------------------------------------------------------------------

        private void dodajKorisnika_btn_Click(object sender, EventArgs e)
        {
            Registracija registracija = new Registracija();
            registracija.tipReg = Registracija.tipRegistracije.ClientAndAdmin;

            registracija.ShowDialog();
        }
        private void dodajIzlet_btn_Click(object sender, EventArgs e)
        {
            DodajIzlet izleti = new DodajIzlet();
            izleti.ShowDialog();
        }

        private void dodajRezervacije_btn_Click(object sender, EventArgs e)
        {
            DodajRezervaciju rezervacije = new DodajRezervaciju();
            rezervacije.tip = DodajRezervaciju.tipForme.admin;
            rezervacije.ShowDialog();
        }

        public static List<T> VratiSelektovaneRedove<T>(DataGridView dataGrid, bool viseredovnaSelekcija, out int brSelektovanih)
        {
            brSelektovanih = 0;
            if (dataGrid.SelectedRows.Count < 1 && viseredovnaSelekcija)
            {
                MessageBox.Show("Nista nije selektovano");
                return new List<T>();
            }
            if (dataGrid.SelectedRows.Count != 1 && !viseredovnaSelekcija)
            {
                MessageBox.Show("Nista nije selektovano ili ste selektovali vise od jednog reda");
                return new List<T>();
            }

            List<T> listaT = new List<T>();
            foreach (DataGridViewRow row in dataGrid.SelectedRows)
            {
                if (row.DataBoundItem is T)
                {
                    T obj = (T)row.DataBoundItem;
                    listaT.Add(obj);
                    brSelektovanih++;
                }
                else
                {
                    throw new Exception("Selektovani red nije tipa: " + typeof(T).Name);
                }

            }
            return listaT;

        }

        //Brisanje----------------------------------------------------------------------
        private void obrisiKorisnika_btn_Click(object sender, EventArgs e)
        {
            bool postojanjeRezervacije;
            int brSelektovanih;
            int brObrisanih = 0;

            //if (GlobalnaLista<Korisnik>.Instanca().Vrati()[0].tipNaloga == tipNaloga.admin)
            //{
            //    MessageBox.Show("Nije moguce brisanje admin naloga!");
            //    return;
            //}

            List<Korisnik> selektovaniKorisnici = VratiSelektovaneRedove<Korisnik>(
                brSelektovanih: out brSelektovanih,
                viseredovnaSelekcija: true,
                dataGrid: korisnici_dgw
                );
            if (selektovaniKorisnici == null || selektovaniKorisnici.Count == 0)
                return;

            for (int i = 0; i < selektovaniKorisnici.Count; i++)
            {

                if (selektovaniKorisnici[i].tipNaloga == tipNaloga.admin)
                {
                    MessageBox.Show("Nije moguce brisanje admin naloga: " + selektovaniKorisnici[i].ime);
                    selektovaniKorisnici.Remove(selektovaniKorisnici[i]);
                    i--;
                }

            }

            foreach (Korisnik kor in selektovaniKorisnici)
            {
                postojanjeRezervacije = false;
                foreach (IzletRezervacija rez in GlobalnaLista<IzletRezervacija>.Instanca().Vrati())
                {
                    if (kor.id == rez.idKorisnika)
                    {
                        MessageBox.Show("Nije moguce obrisati klijenta: " + kor.ime + " " + kor.prezime + " jer poseduje rezervacije!");
                        postojanjeRezervacije = true;
                        break;
                    }
                }
                if (!postojanjeRezervacije)
                {
                    GlobalnaLista<Korisnik>.Instanca().Ukloni(kor);
                    brObrisanih++;
                }

            }

            if (brObrisanih == 1)
                MessageBox.Show("Obrisan je korisnik");
            else if (brObrisanih > 1)
                MessageBox.Show("Obrisano je: " + brObrisanih + " korisnika!");
        }

        private void obrisiIzlet_btn_Click(object sender, EventArgs e)
        {

            int brSelektovanih;
            List<Izlet> selektovaniIzleti = VratiSelektovaneRedove<Izlet>(
                brSelektovanih: out brSelektovanih,
                dataGrid: izleti_dgw,
                viseredovnaSelekcija: true
                );
            if (selektovaniIzleti == null || selektovaniIzleti.Count == 0)
                return;


            foreach (Izlet izlet in selektovaniIzleti)
            {
                bool izletImaRezervaciju = false;

                //Ne smemo da brisemo izlete koji imaju rezervacije
                foreach (IzletRezervacija rez in GlobalnaLista<IzletRezervacija>.Instanca().Vrati())
                {
                    if (rez.idIzleta == izlet.id)
                    {
                        izletImaRezervaciju = true;
                        //GlobalnaLista<Rezervacija>.Instanca().Ukloni(rez);
                    }

                }
                if (izletImaRezervaciju)
                {
                    MessageBox.Show("Nije moguce obrisati izlet: " + izlet.mesto + "(" + izlet.datum + ")" + "jer sadrzi rezervacije");
                    return;
                }
                else
                {
                    izlet.zastareo = true;
                    GlobalnaLista<Izlet>.Instanca().OsveziFajl();
                    //GlobalnaLista<Izlet>.Instanca().Ukloni(izlet);
                }
            }

            if (brSelektovanih == 1)
                MessageBox.Show("Obrisan je izlet!");
            else
                MessageBox.Show("Obrisano je: " + brSelektovanih + " izleta!");
        }

        private void obrisiRezervacije_btn_Click(object sender, EventArgs e)
        {

            int brSelektovanih;
            List<IzletRezervacija> selektovaneIzletRezervacije = VratiSelektovaneRedove<IzletRezervacija>(
                brSelektovanih: out brSelektovanih,
                viseredovnaSelekcija: true,
                dataGrid: rezervacije_dgw
                );
            if (selektovaneIzletRezervacije == null || selektovaneIzletRezervacije.Count == 0)
                return;


            foreach (IzletRezervacija rez in selektovaneIzletRezervacije)
            {

                GlobalnaLista<IzletRezervacija>.Instanca().Ukloni(rez);
                rez.zastareo = true;
                rez.oslobodiRezervaciju();
                GlobalnaLista<Rezervacija>.Instanca().OsveziFajl();
            }

            if (brSelektovanih == 1)
                MessageBox.Show("Uspesno obrisana rezervacija!");
            else
                MessageBox.Show("Obrisano je: " + brSelektovanih + " rezervacija!");
        }

        //Izmeni----------------------------------------------------------------------

        private void izmeniKorisnika_btn_Click(object sender, EventArgs e)
        {

            int brSelektovanih;
            List<Korisnik> selektovaniKorisnici = VratiSelektovaneRedove<Korisnik>(
                brSelektovanih: out brSelektovanih,
                viseredovnaSelekcija: false,
                dataGrid: korisnici_dgw
                );
            if (selektovaniKorisnici.Count == 0 || selektovaniKorisnici == null)
                return;

            Korisnik korisnikZaIzmenu = selektovaniKorisnici[0];

            //GlobalnaLista<Korisnik>.Instanca().Ukloni(korisnikZaIzmenu);

            Registracija registracijaZaIzmenu = new Registracija(korisnikZaIzmenu.id, korisnikZaIzmenu.ime, korisnikZaIzmenu.prezime, korisnikZaIzmenu.korisnickoIme, korisnikZaIzmenu.lozinka, korisnikZaIzmenu.tipNaloga);

            if (korisnikZaIzmenu.tipNaloga == tipNaloga.admin)
                registracijaZaIzmenu.tipReg = Registracija.tipRegistracije.onlyClient;
            else
                registracijaZaIzmenu.tipReg = Registracija.tipRegistracije.ClientAndAdmin;


            registracijaZaIzmenu.ShowDialog();

        }

        private void izmeniIzlet_btn_Click(object sender, EventArgs e)
        {
            int brSelektovanih;

            List<Izlet> selektovaniIzleti = VratiSelektovaneRedove<Izlet>(
                brSelektovanih: out brSelektovanih,
                viseredovnaSelekcija: false,
                dataGrid: izleti_dgw
                );

            if (selektovaniIzleti.Count == 0 || selektovaniIzleti == null)
                return;

            Izlet izletZaIzmenu = selektovaniIzleti[0];

            DodajIzlet izlet = new DodajIzlet(izletZaIzmenu.id, izletZaIzmenu.mesto, izletZaIzmenu.drzava, izletZaIzmenu.cena, izletZaIzmenu.popust, izletZaIzmenu.brojDana, izletZaIzmenu.ukupnoMesta, izletZaIzmenu.datum);

            izlet.ShowDialog();


        }
        private void izmeniRezervacije_btn_Click(object sender, EventArgs e)
        {
            int brSelektovanih;

            List<IzletRezervacija> selektovaneIzletRezervacije = VratiSelektovaneRedove<IzletRezervacija>(
                brSelektovanih: out brSelektovanih,
                viseredovnaSelekcija: false,
                dataGrid: rezervacije_dgw
                );

            if (selektovaneIzletRezervacije.Count == 0 || selektovaneIzletRezervacije == null)
                return;

            IzletRezervacija rezZaIzmenu = selektovaneIzletRezervacije[0];

            rezZaIzmenu.oslobodiRezervaciju();
            GlobalnaLista<IzletRezervacija>.Instanca().OsveziFajl();

            DodajRezervaciju rezervacije = new DodajRezervaciju(rezZaIzmenu.id, rezZaIzmenu.brRezervisanihMesta, rezZaIzmenu.idKorisnika, rezZaIzmenu.idIzleta);
            rezervacije.tip = DodajRezervaciju.tipForme.admin;

            rezervacije.ShowDialog();


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Rezervacije_Click(object sender, EventArgs e)
        {

        }

        private void rezervacije_dgw_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (Utils.CountVIsibleRows(izleti_dgw) == 0)
                return;

            if (Utils.CountVIsibleRows(rezervacije_dgw) != 0)
            {
                rezervacije_dgw.Columns["id"].Visible = false;
                rezervacije_dgw.Columns["idIzleta"].Visible = false;
                rezervacije_dgw.Columns["idKorisnika"].Visible = false;
                rezervacije_dgw.Columns["zastareo"].Visible = false;
                rezervacije_dgw.Columns["zastareoIzlet"].Visible = false;
                rezervacije_dgw.Columns["zastareoRez"].Visible = false;
            }


            List<IzletRezervacija> izlRez = Utils.KreiranjeIzletRezervacija();

            Utils.SakrijZastareleLinije<IzletRezervacija>(rezervacije_dgw);

            if (!onlyOnce)
            {
                DataGridViewTextBoxColumn kolona = new DataGridViewTextBoxColumn();
                kolona.Name = "klijent";
                kolona.HeaderText = "klijent";
                rezervacije_dgw.Columns.Add(kolona);
                onlyOnce = true;
            }

            foreach (DataGridViewRow row in rezervacije_dgw.Rows)
            {
                var klijent = (from sve in izlRez
                               where (string)sve.idKorisnika == (string)row?.Cells?["idKorisnika"]?.Value
                               select sve.idKorisnika).FirstOrDefault();

                Korisnik kor = GlobalnaLista<Korisnik>.Instanca().VratiPoId(klijent);
                string ime = kor.ime + " " + kor.prezime;
                row.Cells["klijent"].Value = ime;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<IzletRezervacija> selektovaneIzletRezervacije = VratiSelektovaneRedove<IzletRezervacija>(
            brSelektovanih: out int brSelektovanih,
            viseredovnaSelekcija: false,
            dataGrid: rezervacije_dgw
            );

            var korisnikInfo = (from korisnik in GlobalnaLista<Korisnik>.Instanca().Vrati()
                                where korisnik.id == selektovaneIzletRezervacije[0].idKorisnika
                                select korisnik).FirstOrDefault();

            MessageBox.Show("Info o klijentu:\nIme: " + korisnikInfo.ime + "\nKorisnicko ime: " + korisnikInfo.korisnickoIme);





        }

        private void izleti_dgw_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Utils.SakrijZastareleLinije<Izlet>(izleti_dgw);

            if (Utils.CountVIsibleRows(izleti_dgw) != 0)
            {
                izleti_dgw.Columns["id"].Visible = false;
                izleti_dgw.Columns["zastareo"].Visible = false;
            }




        }

        private void korisnici_dgw_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (Utils.CountVIsibleRows(korisnici_dgw) != 0)
            {
                korisnici_dgw.Columns["id"].Visible = false;
            }
        }
    }
}
