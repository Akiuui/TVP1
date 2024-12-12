using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_Projekat.OsnovneKlase
{
    public class FajlAkcije
    {
        public static void UpisiUJson(string imeFajla, string jsonString)
        {
            try
            {

                using (StreamWriter sw = File.CreateText(imeFajla.ToLower()))
                {
                    sw.WriteLine(jsonString);
                }


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void ProcitajIzJsonUListu<T>() where T : class, IHaveId{
            string imeFajla = typeof(T).Name + ".json";
            
            try
            {
                string jsonFile = File.ReadAllText(imeFajla);

                jsonFile = jsonFile
                            .Replace("[", "")
                            .Replace("]", "")
                            .Replace("},", "}");

                string[] jsonFileArray = jsonFile.Split("}");

                for (int i = 0; i < jsonFileArray.Length - 1; i++)
                {
                    string singleJson = new string(jsonFileArray[i].Append('}').ToArray());
                    T obj = JsonConvert.DeserializeObject<T>(singleJson)!;
                    GlobalnaLista<T>.Instanca().Dodaj(obj);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Error: Fajl nije nadjen- {imeFajla}");
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: Dogodila se greska pri citanju iz JSONa");
                throw new Exception(ex.Message);

            }
        }
    }
}
