using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVP_Projekat.OsnovneKlase
{
    public partial class IstorijaRezervacija : Form
    {
        string idKorisnika;
        public IstorijaRezervacija(string idKorisnika)
        {
            InitializeComponent();

            this.idKorisnika = idKorisnika;
        }

        private void IstorijaRezervacija_Load(object sender, EventArgs e)
        {


            pocetniDatum_dt.ValueChanged += PocetniDatum_dt_ValueChanged;
            krajnjiDatum_dt.ValueChanged += PocetniDatum_dt_ValueChanged;

            pocetniDatum_dt.Value = DateTime.Now.AddYears(-5);
            krajnjiDatum_dt.Value = DateTime.Now.AddYears(5);
        }

        private void PocetniDatum_dt_ValueChanged(object? sender, EventArgs e)
        {
            if (pocetniDatum_dt.Value > krajnjiDatum_dt.Value)
            {
                MessageBox.Show("Krajnji datum je veci od pocetnog, to narusava Filter");
                return;
            }

            //MessageBox.Show("Aktivirao se");

            List<Rezervacija> temp = new List<Rezervacija>();

            foreach (Rezervacija izlRez in GlobalnaLista<Rezervacija>.Instanca().Vrati())
            {
                Izlet izl = GlobalnaLista<Izlet>.Instanca().VratiPoId(izlRez.idIzleta);

                DateTime datum1 = izl.datum;
                DateTime datum2 = izl.datum.AddDays(izl.brojDana);

                if (pocetniDatum_dt.Value < datum2 && krajnjiDatum_dt.Value >= datum1 && izlRez.idKorisnika == idKorisnika)
                    temp.Add(izlRez);
            }


            izlRez_dgw.DataSource = temp;

            if (GlobalnaLista<Rezervacija>.Instanca().Vrati().Count > 0 && izlRez_dgw.Columns["idIzleta"].Visible == true)
            {
                izlRez_dgw.Columns["idIzleta"].Visible = false;
                izlRez_dgw.Columns["idKorisnika"].Visible = false;
                izlRez_dgw.Columns["zastareo"].Visible = false;

                izlRez_dgw.Columns["id"].Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Rezervacija> selektovaneRezervacije = Administrator.VratiSelektovaneRedove<Rezervacija>(
                brSelektovanih: out int brSelektovanih,
                viseredovnaSelekcija: false,
                dataGrid: izlRez_dgw
                );

            if (selektovaneRezervacije == null || selektovaneRezervacije.Count == 0)
                return;


            Rezervacija izlRez = selektovaneRezervacije[0];

            var izletInfo = (from izlet in GlobalnaLista<Izlet>.Instanca().Vrati()
                             where izlet.id == izlRez.idIzleta
                             select izlet
                            ).FirstOrDefault();

            MessageBox.Show("Info o izletu:\nDrzava: "+izletInfo.drzava+" Mesto: "+izletInfo.mesto+"\nPocetak izleta: "+izletInfo.datum.Date+" Zavrsetak Datuma: "+izletInfo.datum.AddDays(izletInfo.brojDana).Date);

        }
    }
}
