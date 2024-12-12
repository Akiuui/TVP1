using System.Security.Policy;

public interface Izastareo
{
    bool zastareo { get; set; }
}


namespace TVP_Projekat.OsnovneKlase
{
    [Serializable]
    public class Rezervacija : IHaveId
    {
        public string id { get; set; }
        public string idKorisnika { get; set; }
        public string idIzleta { get; set; }
        public double ukupnaCena { get; set; }
        public int brRezervisanihMesta { get; set; }
        public DateTime datumKreacijeRezervacije { get; set; }
        public bool zastareo { get; set; }


        public Rezervacija(string idKorisnika, string idIzleta, int brRezervisanihMesta)
        {
            this.id = Guid.NewGuid().ToString();
            this.idKorisnika = idKorisnika;
            this.idIzleta = idIzleta;
            this.brRezervisanihMesta = brRezervisanihMesta;
            this.datumKreacijeRezervacije = DateTime.Now;
            this.zastareo = false;

            //Generisanje ukupne cene
            Izlet izletRez = GlobalnaLista<Izlet>.Instanca().VratiPoId(idIzleta);
            this.ukupnaCena = this.brRezervisanihMesta * (izletRez.cena - izletRez.popust);
            
            //Smanjivanje slobodnih mesta kod izleta
            izletRez.ukupnoMesta -= brRezervisanihMesta;

            GlobalnaLista<Izlet>.Instanca().Izmeni(
                GlobalnaLista<Izlet>.Instanca().VratiPoId(idIzleta),
                izletRez
                );
        }
        public Rezervacija(string id, string idKorisnika, string idIzleta, int brRezervisanihMesta) {
            this.id = id;
            this.idKorisnika = idKorisnika;
            this.idIzleta = idIzleta;
            this.brRezervisanihMesta = brRezervisanihMesta;
            this.datumKreacijeRezervacije = DateTime.Now;

            //Generisanje ukupne cene
            Izlet izletRez = GlobalnaLista<Izlet>.Instanca().VratiPoId(idIzleta);
            this.ukupnaCena = this.brRezervisanihMesta * izletRez.cena - izletRez.popust;

            //Smanjivanje slobodnih mesta kod izleta
            izletRez.ukupnoMesta -= brRezervisanihMesta;

            GlobalnaLista<Izlet>.Instanca().Izmeni(
                GlobalnaLista<Izlet>.Instanca().VratiPoId(idIzleta),
                izletRez
                );
        }
        public Rezervacija()//-difoltni
        {
            this.id = Guid.NewGuid().ToString();
            this.idKorisnika = "";
            this.idIzleta = "";
            this.brRezervisanihMesta = 0;
            this.ukupnaCena = 0; 
            this.datumKreacijeRezervacije = DateTime.MinValue.Date;

        }

        public void kreirajRezervaciju()
        {
            GlobalnaLista<Rezervacija>.Instanca().Dodaj(this);
        }
        public void oslobodiRezervaciju() {
            Izlet izlet = GlobalnaLista<Izlet>.Instanca().VratiPoId(this.idIzleta);
            izlet.ukupnoMesta += brRezervisanihMesta;

            GlobalnaLista<Izlet>.Instanca().Izmeni(
                GlobalnaLista<Izlet>.Instanca().VratiPoId(this.idIzleta),
                izlet
            );
        }
        public Korisnik getKorisnik() {

            return (from korisnik in GlobalnaLista<Korisnik>.Instanca().Vrati()
                      where korisnik!=null && korisnik.id == this.id
                      select korisnik).FirstOrDefault();
        
        }
        public override string? ToString()
        {
            return "Broj rezervisanih mesta: "+ this.brRezervisanihMesta + " Ukupna cena: "+ this.ukupnaCena + " Datum kreirane rezervacije: "+this.datumKreacijeRezervacije.ToString("dd-MM-yy");
        }
    }
}
