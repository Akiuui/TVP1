using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Text.Json;
using System.IO;
using Newtonsoft.Json;

namespace TVP_Projekat.OsnovneKlase
{
    [Serializable]

    public enum tipNaloga { admin, klijent }
    public class Korisnik : IHaveId
    {
        public string id { get; set;  }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string korisnickoIme { get; set; }
        public string lozinka { get; set; }
        public tipNaloga tipNaloga { get; set; }

        public Korisnik(string ime, string prezime, string korisnickoIme, string lozinka, tipNaloga tipNaloga)
        {
            this.id = Guid.NewGuid().ToString();
            this.ime = ime;
            this.prezime = prezime;
            this.korisnickoIme = korisnickoIme;
            this.lozinka = lozinka;
            this.tipNaloga = tipNaloga;
        }

        public Korisnik(string id, string ime, string prezime, string korisnickoIme, string lozinka, tipNaloga tipNaloga)
        {//konstruktor za azuriranje
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            this.korisnickoIme = korisnickoIme;
            this.lozinka = lozinka;
            this.tipNaloga = tipNaloga;
        }

        public Korisnik()//Default-konstruktor
        {
            id = Guid.NewGuid().ToString();
            ime = "";
            prezime = "";
            korisnickoIme = "";
            lozinka = "";
            tipNaloga = tipNaloga.klijent;
        }

        public void RegistrujKorisnika()
        {

            GlobalnaLista<Korisnik>.Instanca().Dodaj(this);

            MessageBox.Show("Uspesno registrovanje");

        }

        public override string? ToString()
        {
            return "id: " + id + " ime: " + ime + " prezime: " + prezime + " korisnickoIme: " + korisnickoIme + " lozinka: " + lozinka + " tip: " + tipNaloga;
        }
      
    }
}
