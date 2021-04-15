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
        //    Spara.ReadToFile();
        //}


        public static void ReadFromFile()
        {
            // Open the file to read from.
            //string[] readText = File.ReadAllLines(path, Encoding.UTF8);
            //foreach (string s in readText)
            //{
            //    Console.WriteLine(s);
            //}

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(path).ToList();
            List<PRuta> PRutor = new List<PRuta>();

            lines = File.ReadAllLines(path).ToList();
            foreach(string line in lines)
            {
                string[] items = line.Split(" | ");
                PRuta p = new PRuta(items[0]);
                PRutor.Add(p);
            }

            foreach(PRuta p in PRutor)
            {
                Console.WriteLine(p);
            }
        }

        public static void ReadToFile()
        {
            // deletes the old file and creates a new file and then saves the parking list to that file.
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
