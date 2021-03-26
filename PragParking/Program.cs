using System;

namespace PragParking
{
    public class Program
    {
        PHus pHus = new PHus();
        static void Main(string[] args)
        {
            // Vi behöver fordon, varför inte skapa en klass?
            Fordon fordon = new Fordon(); // Nytt Fordon
            PRuta pRuta = new PRuta(); // Skapar P-Ruta
            PHus.skapaPHus();  // Skapar P-Hus

            bool cont = true;

            while (cont)
            {
                Console.Clear();
                Console.WriteLine("Välkommen till Prague Parking");
                Console.WriteLine("Vad vill du göra? ");
                Console.WriteLine("");
                Console.WriteLine("1)  Parkera fordon");
                Console.WriteLine("2)  Kolla efter lediga platser");
                Console.WriteLine("3)  Exit");

                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        int hittaPlats = PHus.hittaLedigPRuta();
                        Console.WriteLine(hittaPlats);
                        break;

                    case "2":
                        foreach (var Ruta in PHus.PRutor)
                        {
                            Console.WriteLine($"Ruta {Ruta.Nummer} är ledig {Ruta.Ledig}");
                        }
                        Console.ReadKey();
                        break;

                    case "3":
                        cont = false; 
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val. Försök igen: ");
                        Console.ReadKey();
                        break;
                }
            }


            // Dags att skapa ett P hus
            // Kontrollerar att huset skapades
            //foreach (var Ruta in PHus.PRutor)
            //{
            //    Console.WriteLine($"Ruta {Ruta.Nummer} är ledig {Ruta.Ledig}");
            //}

            //// Dags att parkera ett fordon i P-Huset

            //// 1. Hitta ledig plats
            //int hittaPlats = PHus.hittaLedigPRuta();
            //Console.WriteLine(hittaPlats);
            //// 2. Parkera fordonet

            //// Repetera fordonsparkering ett antal gånger
            //foreach (var Ruta in PHus.PRutor)
            //{
            //    Console.WriteLine($"Ruta {Ruta.Nummer} är ledig {Ruta.Ledig}");
            //}
            //Console.ReadKey();

        }
    }
}
