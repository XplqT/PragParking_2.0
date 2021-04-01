using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PragParking
{
    public class Spara
    {
        public static void Save()
        {
            string filepath = @"C:\Parking\ParkeringsLista.txt";

            List<string> linjer = new List<string>();
            List<PRuta> rutor = new List<PRuta>();

            linjer = File.ReadAllLines(filepath).ToList();
            foreach (String linje in linjer)
            {
                string[] items = linje.Split(" || ");
                PRuta p = new PRuta(items[0], items[1]);
                rutor.Add(p);
            }


            foreach (PRuta p in rutor)
            {
                Console.WriteLine(p);
            }
            Console.ReadKey();
        }
    }
}
