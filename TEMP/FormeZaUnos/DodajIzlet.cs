using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVP_Projekat.OsnovneKlase;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace TVP_Projekat
{
    public partial class DodajIzlet : Form
    {

        string idZaAzuriranje = "";
        public DodajIzlet()
        {
            InitializeComponent();
        }
        public DodajIzlet(string id, string mesto, string drzava, double cena, int popust, int brojDana, int ukupnoMesta, DateTime datum)
        {
            InitializeComponent();

            mesto_txt.Text = mesto;
            drzava_txt.Text = drzava;
            cena_txt.Text = cena.ToString();
            popust_txt.Text = popust.ToString();
            brojDana_txt.Text = brojDana.ToString();
            ukupnoMesta_txt.Text = ukupnoMesta.ToString();
            datum_date.Value = datum;

            idZaAzuriranje = id;
        }

        private void izleti_btn_Click(object sender, EventArgs e)
        {
            if (Provere.DaLiPostojeGreske(Controls))
                return;


            string mesto = mesto_txt.Text;
            string drzava = drzava_txt.Text;
            double cena = double.Parse(cena_txt.Text);
            int popust = int.Parse(popust_txt.Text);
            int brojDana = int.Parse(brojDana_txt.Text);
            int ukupnoMesta = int.Parse(ukupnoMesta_txt.Text);
            DateTime datum = datum_date.Value;


            if (idZaAzuriranje == "")
            {

                Izlet izlet = new Izlet(mesto, drzava, cena, popust, brojDana, ukupnoMesta, datum);

                izlet.kreirajIzlet();
                this.Close();
            }
            else
            {

                Izlet izlet = new Izlet(idZaAzuriranje, mesto, drzava, cena, popust, brojDana, ukupnoMesta, datum);
                izlet.kreirajIzlet();

                Izlet stariIzlet = GlobalnaLista<Izlet>.Instanca().VratiPoId(idZaAzuriranje);
                GlobalnaLista<Izlet>.Instanca().Ukloni(stariIzlet);
                
                idZaAzuriranje = "";
                this.Close();

            }

        }

        private void DodajIzlet_Load(object sender, EventArgs e)
        {
            Provere.DodajProveruUnosa(Controls);
            datum_date.MinDate = DateTime.Now;
        }
    }
}
