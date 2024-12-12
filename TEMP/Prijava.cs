using Newtonsoft.Json;
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

namespace TVP_Projekat
{
    public partial class Prijava : Form
    {
        public Prijava()
        {
            InitializeComponent();
        }

        private void prijava_btn_Click(object sender, EventArgs e)
        {
            if (Provere.DaLiPostojeGreske(Controls))
                return;

            string korIme = ime_txt.Text;
            string lozinka = lozinka_txt.Text;
            Korisnik korisnik = new Korisnik();

            foreach (Korisnik kor in GlobalnaLista<Korisnik>.Instanca().Vrati())
            {
                if (kor.korisnickoIme == korIme)
                    korisnik = kor;
            }

            if (korisnik.korisnickoIme == korIme && korisnik.lozinka== lozinka)
            {
                ime_txt.Clear();
                lozinka_txt.Clear();

                MessageBox.Show("Uspesno ste se ulogovali");

                if (korisnik.tipNaloga == tipNaloga.klijent)
                {
                    Klijent KlijentForma = new Klijent(korisnik);
                    KlijentForma.ShowDialog();
                }
                else if (korisnik.tipNaloga == tipNaloga.admin)
                {
                    Administrator AdministratorForma = new Administrator();
                    AdministratorForma.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show("Korisnik ne postoji");
            }

        }

        private void Prijava_Load(object sender, EventArgs e)
        {
            Provere.DodajProveruUnosa(Controls);


            FileInfo fajlInfo = new FileInfo(nameof(Korisnik) + ".json");
            if (File.Exists(nameof(Korisnik) + ".json") && fajlInfo.Length != 0)
            {
                FajlAkcije.ProcitajIzJsonUListu<Korisnik>();
            }
            else
            {
                Registracija registracija = new Registracija();
                registracija.tipReg = Registracija.tipRegistracije.onlyAdmin;
                registracija.ShowDialog();
            }
            //Proverava zastarelost izleta
            if (File.Exists(nameof(Izlet) + ".json")) { 
                FajlAkcije.ProcitajIzJsonUListu<Izlet>();

                List<Izlet> izleti = GlobalnaLista<Izlet>.Instanca().Vrati();
                for(int i = 0; i < izleti.Count; i++)
                {
                    //izleti[i].zastareo = false;
                    if (izleti[i].datum.AddDays(izleti[i].brojDana).Date < DateTime.Now.Date)
                    {
                        izleti[i].zastareo = true;

                    }
                }

                FajlAkcije.UpisiUJson(nameof(Izlet) + ".json", "");
                GlobalnaLista<Izlet>.Instanca().Ocisti();

                
                string jsonString = JsonConvert.SerializeObject(izleti, Formatting.Indented);
                FajlAkcije.UpisiUJson(nameof(Izlet) + ".json", jsonString);
                FajlAkcije.ProcitajIzJsonUListu<Izlet>();

            }

            if (File.Exists(nameof(Rezervacija) + ".json"))
                FajlAkcije.ProcitajIzJsonUListu<Rezervacija>();

            if (File.Exists(nameof(IzletRezervacija) + ".json"))
                FajlAkcije.ProcitajIzJsonUListu<IzletRezervacija>();


        }

        private void registrujteSe_txt_Click(object sender, EventArgs e)
        {
            Registracija registracija = new Registracija();
            registracija.tipReg = Registracija.tipRegistracije.onlyClient;
            registracija.ShowDialog();
        }

        Color defaultBtnColor;

        private void registrujteSe_txt_MouseEnter(object sender, EventArgs e)
        {
                Button btn = (Button)sender as Button;
                defaultBtnColor = btn.ForeColor;
                btn.ForeColor = Color.Blue;
        }

        private void registrujteSe_txt_MouseLeave(object sender, EventArgs e)
        {
                Button btn = (Button)sender as Button;
                btn.ForeColor = defaultBtnColor;
        }

    }
}
