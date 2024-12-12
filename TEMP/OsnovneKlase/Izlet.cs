using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TVP_Projekat.OsnovneKlase
{
    [Serializable]
    public class Izlet : IHaveId, Izastareo
    {
        public string id { get; set; }
        public string mesto { get; set; }
        public string drzava { get; set; }
        public double cena { get; set; }
        public int popust { get; set; }
        public int brojDana { get; set; }
        public int ukupnoMesta { get; set; }
        public DateTime datum { get; set; }
        public bool zastareo { get; set; }

        public Izlet()
        {
            Guid myUuid = Guid.NewGuid();
            id = myUuid.ToString();
            mesto = "";
            drzava = "";
            cena = 0.0;
            popust = 0;
            brojDana = 0;
            ukupnoMesta = 0;
            datum = DateTime.MinValue;
            zastareo = false;
        }

        public Izlet(string mesto, string drzava, double cena, int popust, int brojDana, int ukupnoMesta, DateTime datum)
        {
            Guid myUuid = Guid.NewGuid();
            id = myUuid.ToString();
            this.mesto = char.ToUpper(mesto[0]) + mesto.Substring(1).ToLower();
            this.drzava = char.ToUpper(drzava[0]) + drzava.Substring(1).ToLower();
            this.cena = cena;
            this.popust = popust;
            this.brojDana = brojDana;
            this.ukupnoMesta = ukupnoMesta;
            this.datum = datum.Date;
            this.zastareo = false;
        }
        public Izlet(string id, string mesto, string drzava, double cena, int popust, int brojDana, int ukupnoMesta, DateTime datum)
        {//konstruktor za azuriranje
            this.id = id;
            this.mesto = char.ToUpper(mesto[0]) + mesto.Substring(1).ToLower();
            this.drzava = char.ToUpper(drzava[0]) + drzava.Substring(1).ToLower();
            this.cena = cena;
            this.popust = popust;
            this.brojDana = brojDana;
            this.ukupnoMesta = ukupnoMesta;
            this.datum = datum.Date;
            this.zastareo = false;

        }

        public void kreirajIzlet()
        {
            GlobalnaLista<Izlet>.Instanca().Dodaj(this);

            MessageBox.Show("Uspesno kreiran izlet!");
        }
        public bool preklapanjeIzleta(Izlet izlet) {

            DateTime pocetniDatum1 = this.datum;
            DateTime zavrsniDatum1 = this.datum.AddDays(this.brojDana - 1);

            DateTime pocetniDatum2 = izlet.datum;
            DateTime zavrsniDatum2 = izlet.datum.AddDays(izlet.brojDana - 1);

            if (pocetniDatum1 <= zavrsniDatum2 && zavrsniDatum1 >= pocetniDatum2)
                return true;
            else
                return false;



        }
        public override string? ToString()
        {
            return "Drzava: " + this.drzava+" Mesto: " +this.mesto+" Cena: "+this.cena+" Popust: "+this.popust+" Broj dana: "+this.brojDana+" Ukupno slobodnih mesta: "+this.ukupnoMesta+" Datum izleta: "+this.datum.ToString("dd-MM-yy");
        }


    }
}
