using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PragParking
{
    public class Spara
    {
        public static string path = @"C:\Parking\ParkeringsLista.txt";

        //public static void Save()
        //{
        //    // This text is added only once to the file.
        //    Spara.ReadToFile();
        //}

        public static void ReadFromFile()
        {
            // Open the file to read from.
            string[] readText = File.ReadAllLines(path, Encoding.UTF8);
            foreach (string s in readText)
            {
                Console.WriteLine(s);
            }
        }

        public static void ReadToFile()
        {
            // This text is always added, making the file longer over time
            File.Delete(path);
            foreach (var Ruta in PHus.PRutor)
            {
                string appendText = $"{Ruta.Nummer};{Ruta.Ledig};{Ruta.Regnr}" + Environment.NewLine;
                File.AppendAllText(path, appendText, Encoding.UTF8);
            }
        }

            


            //File.WriteAllLines(sparadfil, (IEnumerable<string>)PHus.PRutor);


            //foreach (var Ruta in PHus.PRutor)
            //{
            //    Console.WriteLine($"Ruta {Ruta.Nummer} är ledig {Ruta.Ledig}");
            //    File.WriteAllLines(sparadfil, $"Ruta {Ruta.Nummer} är ledig {Ruta.Ledig}");
            //}
            //Console.ReadKey();


            //List<string> linjer = new List<string>();
            //List<PRuta> rutor = new List<PRuta>();

            //linjer = File.ReadAllLines(filepath).ToList();
            //foreach (String linje in linjer)
            //{
            //    string[] items = linje.Split(" || ");
            //    PRuta p = new PRuta(items[0], items[1]);
            //    rutor.Add(p);
            //}


            //foreach (PRuta p in rutor)
            //{
            //    Console.WriteLine(p);
            //}            
       
    }
}
