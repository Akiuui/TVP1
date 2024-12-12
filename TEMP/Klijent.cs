using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVP_Projekat.FormeZaUnos;
using TVP_Projekat.OsnovneKlase;

namespace TVP_Projekat
{
    public partial class Klijent : Form
    {
        private Korisnik ulogovaniKorisnik;
        public Klijent(Korisnik ulogovaniKor)
        {
            InitializeComponent();
            this.ulogovaniKorisnik = ulogovaniKor;
        }

        private void Klijent_Load(object sender, EventArgs e)
        {
            Provere.DodajProveruUnosa(Controls);

            //Kreiramo IzletRezervacija listu
            List<IzletRezervacija> izletRezervacijeKorisnika = new List<IzletRezervacija>();

            foreach (IzletRezervacija izlRez in GlobalnaLista<IzletRezervacija>.Instanca().Vrati())
            {

                if (ulogovaniKorisnik.id == izlRez.idKorisnika)
                    izletRezervacijeKorisnika.Add(izlRez);

            }
            //izletRezervacija = Utils.KreiranjeIzletRezervacija();
            rezervacijeKlijenta_dgw.DataSource = izletRezervacijeKorisnika;
            //Utils.PunjenjeIzletRezervacijaDGW(izletRezervacija, rezervacijeKlijenta_dgw);
            //Utils.SakrijZastareleLinije<IzletRezervacija>(rezervacijeKlijenta_dgw);

            GlobalnaLista<Korisnik>.Instanca().dogodilaSePromena += Klijent_dogodilaSePromena;
            GlobalnaLista<Izlet>.Instanca().dogodilaSePromena += Klijent_dogodilaSePromena;
            GlobalnaLista<Rezervacija>.Instanca().dogodilaSePromena += Klijent_dogodilaSePromena;

        }
        private void Klijent_dogodilaSePromena(object? sender, EventArgs e)
        {
            List<IzletRezervacija> izletRezervacijeKorisnika = new List<IzletRezervacija>();

            foreach (IzletRezervacija izlRez in GlobalnaLista<IzletRezervacija>.Instanca().Vrati())
            {

                if (ulogovaniKorisnik.id == izlRez.idKorisnika)
                    izletRezervacijeKorisnika.Add(izlRez);

            }
            //izletRezervacija = Utils.KreiranjeIzletRezervacija();
            rezervacijeKlijenta_dgw.DataSource = izletRezervacijeKorisnika;


            //Utils.PunjenjeIzletRezervacijaDGW(izletRezervacija, rezervacijeKlijenta_dgw);
            //Utils.SakrijZastareleLinije<IzletRezervacija>(rezervacijeKlijenta_dgw);

        }


        //private List<IzletRezervacija> KreiranjeIzletRezervacija()
        //{
        //    List<Rezervacija> rezervacijeKorisnika = new List<Rezervacija>();
        //    List<IzletRezervacija> IzletRezervacija = new List<IzletRezervacija>();

        //    //foreach (Rezervacija rez in GlobalnaLista<Rezervacija>.Instanca().Vrati())
        //    //{
        //    //    if (rez.idKorisnika == ulogovaniKorisnik.id)
        //    //        rezervacijeKorisnika.Add(rez);
        //    //}

        //    foreach (Rezervacija rez in rezervacijeKorisnika)
        //    {
        //        Izlet izlet = GlobalnaLista<Izlet>.Instanca().VratiPoId(rez.idIzleta);

        //        IzletRezervacija kombinovaneKlase = new IzletRezervacija(izlet.zastareo, rez.zastareo, rez.id, izlet.id, izlet.datum, izlet.drzava, izlet.mesto, izlet.brojDana, rez.ukupnaCena, rez.brRezervisanihMesta, rez.datumKreacijeRezervacije);

        //        IzletRezervacija.Add(kombinovaneKlase);
        //    }

        //    return IzletRezervacija;

        //}


        private void dodajRezervacije_btn_Click(object sender, EventArgs e)
        {
            DodajRezervaciju dodajRez = new DodajRezervaciju(ulogovaniKorisnik);

            dodajRez.tip = DodajRezervaciju.tipForme.client;

            dodajRez.ShowDialog();
        }

        private void obrisiRezervacije_btn_Click(object sender, EventArgs e)
        {
            List<IzletRezervacija> selektovaneIzletRezervacije = Administrator.VratiSelektovaneRedove<IzletRezervacija>(
                brSelektovanih: out int brSelektovanih,
                viseredovnaSelekcija: true,
                dataGrid: rezervacijeKlijenta_dgw
                );

            if (selektovaneIzletRezervacije == null || selektovaneIzletRezervacije.Count == 0)
                return;



            foreach (IzletRezervacija izlRez in selektovaneIzletRezervacije)
            {
                GlobalnaLista<IzletRezervacija>.Instanca().Ukloni(izlRez);
                izlRez.zastareo = true;
                izlRez.oslobodiRezervaciju();
                GlobalnaLista<Rezervacija>.Instanca().OsveziFajl();

            }

            if (brSelektovanih == 1)
                MessageBox.Show("Uspesno obrisana rezervacija!");
            else
                MessageBox.Show("Obrisano je: " + brSelektovanih + " rezervacija!");
        }
        private void izmeniRezervacije_btn_Click(object sender, EventArgs e)
        {
            List<IzletRezervacija> selektovaneRezervacije = Administrator.VratiSelektovaneRedove<IzletRezervacija>(
               brSelektovanih: out int brSelektovanih,
               viseredovnaSelekcija: false,
               dataGrid: rezervacijeKlijenta_dgw
               );

            if (selektovaneRezervacije.Count == 0 || selektovaneRezervacije == null)
                return;

            IzletRezervacija izletRez = selektovaneRezervacije[0];

            Rezervacija rezZaIzmenu = GlobalnaLista<Rezervacija>.Instanca().VratiPoId(izletRez.id);

            rezZaIzmenu.oslobodiRezervaciju();
            GlobalnaLista<IzletRezervacija>.Instanca().OsveziFajl();

            DodajRezervaciju dodajRez = new DodajRezervaciju(ulogovaniKorisnik, rezZaIzmenu.id, rezZaIzmenu.brRezervisanihMesta, rezZaIzmenu.idKorisnika, rezZaIzmenu.idIzleta);
            dodajRez.tip = DodajRezervaciju.tipForme.client;

            dodajRez.ShowDialog();
        }

        private void detalji_btn_Click(object sender, EventArgs e)
        {
            List<IzletRezervacija> selektovaneRezervacije = Administrator.VratiSelektovaneRedove<IzletRezervacija>(
                brSelektovanih: out int brSelektovanih,
                viseredovnaSelekcija: false,
                dataGrid: rezervacijeKlijenta_dgw
                );

            if (selektovaneRezervacije == null || selektovaneRezervacije.Count == 0)
                return;


            IzletRezervacija izlRez = selektovaneRezervacije[0];

            //Rezervacija rez = GlobalnaLista<Rezervacija>.Instanca().VratiPoId(izlRez.id);
            //Izlet selektovanIzlet = GlobalnaLista<Izlet>.Instanca().VratiPoId(izlRez.idIzleta);

            var klijentInfo = (from korisnik in GlobalnaLista<Korisnik>.Instanca().Vrati()
                               where korisnik.id == izlRez.idKorisnika
                               select korisnik 
                               ).FirstOrDefault();

            MessageBox.Show("Info o korisniku\nIme: "+klijentInfo.ime + " Prezime: "+klijentInfo.prezime+" Korisnicko Ime: "+klijentInfo.korisnickoIme);

        }

        private void sveRezervacije_btn_Click(object sender, EventArgs e)
        {
            IstorijaRezervacija frm = new IstorijaRezervacija(ulogovaniKorisnik.id);
            frm.ShowDialog();
        }

        private void rezervacijeKlijenta_dgw_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            rezervacijeKlijenta_dgw.Columns["idKorisnika"].Visible = false;
            rezervacijeKlijenta_dgw.Columns["id"].Visible = false;
            rezervacijeKlijenta_dgw.Columns["idIzleta"].Visible = false;
            rezervacijeKlijenta_dgw.Columns["zastareo"].Visible = false;
            rezervacijeKlijenta_dgw.Columns["zastareoIzlet"].Visible = false;
            rezervacijeKlijenta_dgw.Columns["zastareoRez"].Visible = false;



        }
    }
}
