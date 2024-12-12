using Microsoft.AspNetCore.Identity;
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
using static System.Net.Mime.MediaTypeNames;

namespace TVP_Projekat
{
    public partial class Registracija : Form
    {
        string idZaAzuriranje = "";

        public enum tipRegistracije { onlyAdmin, onlyClient, ClientAndAdmin }
        public tipRegistracije tipReg;
        public Registracija()
        {
            InitializeComponent();
        }
        public Registracija(string id, string ime, string prezime, string korIme, string lozinka, tipNaloga a)
        {
            InitializeComponent();

            ime_txt.Text = ime;
            prezime_txt.Text = prezime;
            korIme_txt.Text = korIme;
            lozinka_txt.Text = lozinka;

            if (a == tipNaloga.klijent)
                klijent_rdbtn.Checked = true;
            else
                administrator_rdbtn.Checked = true;

            idZaAzuriranje = id;
        }
        private static bool SadrziPrazneZnakove(string s)
        {
            foreach (char c in s)
            {
                if (c == '\t' || c == '\n' || c==' ')
                {
                    return true;
                }
            }
            return false;
        }

        private void registracija_btn_Click(object sender, EventArgs e)
        {
            if (Provere.DaLiPostojeGreske(Controls))
                return;

            string ime = ime_txt.Text;
            string prezime = prezime_txt.Text;
            string korIme = korIme_txt.Text;
            string lozinka = lozinka_txt.Text;

            if (lozinka.Length < 6) {
                lozinka_txt.Text = "";
                MessageBox.Show("Sifra je prekratna (duzina treba da bude minimalno 6)");
                return;
            }
            if (SadrziPrazneZnakove(lozinka))
            {
                lozinka_txt.Text = "";
                MessageBox.Show("Sifra je sadrzi prazni karakter");
                return;
            }
            if (SadrziPrazneZnakove(ime))
            {
                ime_txt.Text = "";
                MessageBox.Show("Ime sadrzi prazni karakter");
                return;
            }
            if (SadrziPrazneZnakove(prezime))
            {
                prezime_txt.Text = "";
                MessageBox.Show("Prezime sadrzi prazni karakter");
                return;
            }
            if (SadrziPrazneZnakove(korIme))
            {
                korIme_txt.Text = "";
                MessageBox.Show("Korisnicko imesadrzi prazni karakter");
                return;
            }

            tipNaloga nalog;

            if (klijent_rdbtn.Checked)
                nalog = tipNaloga.klijent;
            else
                nalog = tipNaloga.admin;

            foreach (Korisnik kor in GlobalnaLista<Korisnik>.Instanca().Vrati())
            {
                if (korIme == kor.korisnickoIme)
                {
                    new ErrorProvider().SetError(korIme_txt, "Postoji korisnik sa istim korisnicim imenom, izmislite drugo!");
                    korIme_txt.BorderStyle = BorderStyle.FixedSingle;
                    korIme_txt.BackColor = Color.LightYellow;
                    korIme_txt.ForeColor = Color.Red;
                    return;
                }

            }

            if (idZaAzuriranje != "")
            {
                Korisnik kor = new Korisnik(idZaAzuriranje, ime, prezime, korIme, lozinka, nalog);
                kor.RegistrujKorisnika();
                Korisnik stariKorisnik = GlobalnaLista<Korisnik>.Instanca().VratiPoId(idZaAzuriranje);
                GlobalnaLista<Korisnik>.Instanca().Ukloni(stariKorisnik);

                idZaAzuriranje = "";
                this.Close();
            }
            else
            {

                if (tipReg == tipRegistracije.onlyClient)
                {
                    Korisnik kor = new Korisnik(ime, prezime, korIme, lozinka, tipNaloga.klijent);
                    kor.RegistrujKorisnika();
                    this.Close();
                }

                if (tipReg == tipRegistracije.onlyAdmin)
                {
                    Korisnik kor = new Korisnik(ime, prezime, korIme, lozinka, tipNaloga.admin);
                    kor.RegistrujKorisnika();
                    this.Close();
                }

                if (tipReg == tipRegistracije.ClientAndAdmin)
                {
                    Korisnik kor = new Korisnik(ime, prezime, korIme, lozinka, nalog);
                    kor.RegistrujKorisnika();
                    this.Close();
                }

            }


        }

        private void Registracija_Load(object sender, EventArgs e)
        {
            Provere.DodajProveruUnosa(Controls);


            if (tipReg == tipRegistracije.ClientAndAdmin)
            {
                tipNaloga_lbl.Visible = true;
                kli_amd_lbl.Visible = true;
                klijent_rdbtn.Visible = true;
                administrator_rdbtn.Visible = true;
            }
            else if (tipReg == tipRegistracije.onlyClient)
            {
                klijent_lbl.Visible = true;
                klijent_rdbtn.Visible = false;
                administrator_rdbtn.Visible = false;
            }
            else if (tipReg == tipRegistracije.onlyAdmin)
            {
                administrator_lbl.Visible = true;
                klijent_rdbtn.Visible = false;
                administrator_rdbtn.Visible = false;
            }

        }
    }
}
