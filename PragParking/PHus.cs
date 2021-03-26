using System;
using System.Collections.Generic;
using System.Text;

namespace PragParking
{
    public class PHus
    {
        public static int antalRutor { get; set; } = 10;
        public static List<PRuta> PRutor { get; set; } = new List<PRuta>(antalRutor);
        public static void skapaPHus()
        {
            int i = 1;
            while (i <= antalRutor)
            {
                PRuta newPRuta = new PRuta
                {
                    Nummer = i,
                    Ledig = true,
                    Regnr = null
                };
                PRutor.Add(newPRuta);
                i++;
            }
            return;

        }
        public static int hittaLedigPRuta()
        {
            int i = 0;
            while (i < antalRutor)
            {
                if (PHus.PRutor[i].Ledig == true)
                {
                    Console.WriteLine($"Parkeringsplats nr {i+1} är ledig");
                    Console.WriteLine("Skriv in ditt regnr: ");
                    PHus.PRutor[i].Nummer = i + 1;
                    PHus.PRutor[i].Ledig = false;
                    PHus.PRutor[i].Regnr = Console.ReadLine();
                    Console.WriteLine($"Parkering {PHus.PRutor[i].Nummer} är upptagen och innehåller {PHus.PRutor[i].Regnr}");
                    break;
                }
                i++;
            }
            i = 0;
            //while (i < antalRutor)
            //{
            //    if (PHus.PRutor[i].Ledig == true)
            //    {
            //        Console.WriteLine($"Parkeringsplats nr {i+1} är ledig");
            //        Console.WriteLine("Skriv in ditt regnr: ");
            //        PHus.PRutor[i].Nummer = i + 1;
            //        PHus.PRutor[i].Ledig = false;
            //        PHus.PRutor[i].Regnr = Console.ReadLine();
            //        Console.WriteLine($"Parkering {PHus.PRutor[i].Nummer} är upptagen och innehåller {PHus.PRutor[i].Regnr}");
            //        break;
            //    }
            //    i++;
            //}
            return i;
        }
    }
}
