using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_Projekat.OsnovneKlase
{
    internal class Utils
    {
        public static void SakrijZastareleLinije<T>(DataGridView dgw) where T : Izastareo
        {
            List<T> izleti = (List<T>)dgw.DataSource;
            if (izleti.Count == 0) return;
            for (int i = 0; i < izleti.Count; i++)
            {

                try
                {
                    if (izleti[i].zastareo == true)
                    {
                        dgw.Rows[i].Visible = false;
                    }
                }
                catch (System.InvalidOperationException ex)
                {
                    if (CountVIsibleRows(dgw) == 1){
                        dgw.DataSource = null;
                        return;
                    }
                    //(dgw.BindingContext[dgw.DataSource] as CurrencyManager).Position = i-1;

                    //else {

                    //dgw.Rows[i + 1].Selected = true;
                    (dgw.BindingContext[dgw.DataSource] as CurrencyManager).Position = i + 1;

                    dgw.Rows[i].Visible = false;
                    //}
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        public static int CountVIsibleRows(DataGridView dgw) {
            int br = 0;
            foreach (DataGridViewRow row in dgw.Rows) {
                if (row.Visible)
                    br++;
            }
            return br;
        
        }
        public static void PunjenjeIzletRezervacijaDGW(List<IzletRezervacija> liIzlRez, DataGridView dgw)
        {
                List<IzletRezervacija> izmenjena = new List<IzletRezervacija>();

                foreach (IzletRezervacija izlRez in liIzlRez)
                {
                    if (!izlRez.zastareoIzlet && !izlRez.zastareoRez)
                        izmenjena.Add(izlRez);
                    //if (!izlRez.zastareoIzlet)
                    //    izmenjena.Add(izlRez);
                }

                dgw.DataSource = izmenjena;

                //if (izmenjena.Count > 0)
                //{
                //    rezervacijeKlijenta_dgw.Columns["idIzleta"].Visible = false;
                //    rezervacijeKlijenta_dgw.Columns["idRez"].Visible = false;
                //    rezervacijeKlijenta_dgw.Columns["zastareo"].Visible = false;

                //}

        }

        public static List<IzletRezervacija> KreiranjeIzletRezervacija()
        {
            List<IzletRezervacija> IzletRezervacija = new List<IzletRezervacija>();

            foreach (IzletRezervacija rez in GlobalnaLista<IzletRezervacija>.Instanca().Vrati())
            {
                Izlet izlet = GlobalnaLista<Izlet>.Instanca().VratiPoId(rez.idIzleta);

                IzletRezervacija kombinovaneKlase = new IzletRezervacija(rez.idKorisnika,izlet.zastareo, rez.zastareo, rez.id, izlet.id, izlet.datum, izlet.drzava, izlet.mesto, izlet.brojDana, rez.ukupnaCena, rez.brRezervisanihMesta, rez.datumRezervacije);

                IzletRezervacija.Add(kombinovaneKlase);
            }

            return IzletRezervacija;

        }
        public static void SelektujRedUGrid<T>(T objSelektovan, DataGridView grid) where T : class, IHaveId
        {

            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.ClearSelection();


            foreach (DataGridViewRow row in grid.Rows)
            {

                T izl = (T)row.DataBoundItem;

                if (izl != null && izl.id == objSelektovan.id)
                {
                    row.Selected = true;
                    grid.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }

        }
    }
}
