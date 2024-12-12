using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_Projekat.OsnovneKlase
{
    public class IzletRezervacija : Izastareo, IHaveId
    {
        public string idKorisnika { get; set; }
        public string idIzleta { get; set; }
        public string id { get; set; }
        public bool zastareoIzlet { get; set; }
        public bool zastareoRez { get; set; }
        public bool zastareo { get; set; }

        public DateTime datumIzleta { get; set; }
        public string drzava { get; set; }
        public string mesto { get; set; }
        public int brojDana { get; set; }
        public double ukupnaCena { get; set; }
        public int brRezervisanihMesta { get; set; }
        public DateTime datumRezervacije { get; set; }

        public IzletRezervacija(string idKorisnika,bool zastareoIzlet, bool zastareoRez, string idRez ,string idIzleta, DateTime datumIzleta, string drzava, string mesto, int brojDana, double ukupnaCena, int brRezervisanihMesta, DateTime datumRezervacije)
        {
            this.idKorisnika = idKorisnika;
            this.id = idRez;
            this.idIzleta = idIzleta;
            this.datumIzleta = datumIzleta;
            this.drzava = drzava;
            this.mesto = mesto;
            this.brojDana = brojDana;
            this.ukupnaCena = ukupnaCena;
            this.brRezervisanihMesta = brRezervisanihMesta;
            this.datumRezervacije = datumRezervacije;
            this.zastareoRez = zastareoRez;
            this.zastareoIzlet = zastareoIzlet;
            this.zastareo = zastareoIzlet || zastareoRez;
        }
        public IzletRezervacija()
        {
            this.idKorisnika = "";
            this.idIzleta = "";
            this.datumIzleta = DateTime.MinValue;
            this.drzava = "";
            this.mesto = "";
            this.brojDana = 0;
            this.ukupnaCena = 0.0;
            this.brRezervisanihMesta = 0;
            this.datumRezervacije = DateTime.MinValue;
            this.zastareoRez = false;
            this.zastareoIzlet = false;


        }
        public void oslobodiRezervaciju()
        {
            Izlet izlet = GlobalnaLista<Izlet>.Instanca().VratiPoId(this.idIzleta);
            izlet.ukupnoMesta += brRezervisanihMesta;

            GlobalnaLista<Izlet>.Instanca().Izmeni(
                GlobalnaLista<Izlet>.Instanca().VratiPoId(this.idIzleta),
                izlet
            );
        }
        public override string? ToString()
        {
            return "datumIzleta: "+datumIzleta +" drzava: "+ drzava +" mesto: "+" brojDana: "+brojDana +" UkupnaCena: "+ukupnaCena+ "brRezervisanihMesta: "+brRezervisanihMesta+" datumRezervacije: "+datumRezervacije ;
        }
    }
}
