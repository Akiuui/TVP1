using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IHaveId
{
    public string id { get; set; }

}

namespace TVP_Projekat.OsnovneKlase
{
    public class GlobalnaLista<T> where T : class, IHaveId
    {
        private static GlobalnaLista<T>? instanca;
        private static readonly object _lock = new object();
        private List<T> lista;
        private string imeFajla = (typeof(T).Name + ".json").ToLower();

        public event EventHandler? dogodilaSePromena;

        private GlobalnaLista()
        {
            lista = new List<T>();
        }
        public static GlobalnaLista<T> Instanca()
        {
            if (instanca == null)
            {

                lock (_lock)
                {
                    if (instanca == null)
                    {

                        instanca = new GlobalnaLista<T>();

                    }
                }

            }
            return instanca;
        }
        public void Dodaj(T instancaT)
        {
            lista.Add(instancaT);

            string jsonString = JsonConvert.SerializeObject(Vrati(), Formatting.Indented);
            FajlAkcije.UpisiUJson(imeFajla, jsonString);
            dogodilaSePromena?.Invoke(this, EventArgs.Empty);
        }
        public void Ukloni(T instancaT)
        {
            lista.Remove(instancaT);

            string jsonString = JsonConvert.SerializeObject(Vrati(), Formatting.Indented);
            FajlAkcije.UpisiUJson(imeFajla, jsonString);
            dogodilaSePromena?.Invoke(this, EventArgs.Empty);

        }
        public void OsveziFajl() {
            string jsonString = JsonConvert.SerializeObject(Vrati(), Formatting.Indented);
            FajlAkcije.UpisiUJson(imeFajla, jsonString);
            dogodilaSePromena?.Invoke(this, EventArgs.Empty);
        }
        public void Izmeni(T stariT, T noviT)
        {
            if (stariT.id != noviT.id) {
                throw new Exception("Objekti koje menjamo nemaju isti id");
            }

            lista.Remove(stariT);
            lista.Add(noviT);//Nov korisnik mora da ima isti id kao stari

            string jsonString = JsonConvert.SerializeObject(Vrati(), Formatting.Indented);
            FajlAkcije.UpisiUJson(imeFajla, jsonString);
            dogodilaSePromena?.Invoke(this, EventArgs.Empty);

        }
        public int BrojElemenata()
        {
            return lista.Count;
        }

        public List<T> Vrati()
        {
            return new List<T>(lista);
        }
        public void Ocisti() {
            lista.Clear();
        }

        public T VratiPoId(string id)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                T t = lista[i];
                if (t.id == id)
                    return t;
            }
            return default!;
        }
    }

}
