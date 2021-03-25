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




            // Vi behöver ett fordon
            Console.WriteLine("Välkommen till PragueParking.");
            Console.WriteLine("Skriv in ditt regnr: ");
            fordon.Regnr = Console.ReadLine();
            Console.WriteLine($"Fordon: {fordon.Regnr}");


            // Nu vill vi parkera fordonet
            pRuta.Nummer = 1;
            pRuta.Ledig = true;
            Console.WriteLine($"Ruta {pRuta.Nummer} är ledig {pRuta.Ledig}");

            if (pRuta.Ledig = true)
                {
                    pRuta.Regnr = fordon.Regnr;
                    pRuta.Ledig = false;
                }

            Console.WriteLine($"Ruta {pRuta.Nummer} är ledig {pRuta.Ledig} där står {pRuta.Regnr}");
            Console.WriteLine("Skriv in ditt regnr: ");
            fordon.Regnr = Console.ReadLine();
            Console.WriteLine($"Fordon: {fordon.Regnr}");
            Console.WriteLine("Nu vill vi parkera fordonet");
            pRuta.Nummer = 2;
            pRuta.Ledig = true;
            Console.WriteLine($"Ruta {pRuta.Nummer} är ledig {pRuta.Ledig}");
            if (pRuta.Ledig = true)
            {
                pRuta.Regnr = fordon.Regnr;
                pRuta.Ledig = false;
            }
            Console.WriteLine($"Ruta {pRuta.Nummer} är ledig {pRuta.Ledig} där står {pRuta.Regnr}");

            // Dags att skapa ett P hus
            // Kontrollerar att huset skapades
            foreach (var Ruta in PHus.PRutor)
            {
                Console.WriteLine($"Ruta {Ruta.Nummer} är ledig {Ruta.Ledig}");
            }

            // Dags att parkera ett fordon i P-Huset

            // 1. Hitta ledig plats
            int hittaPlats = PHus.hittaLedigPRuta();
            Console.WriteLine(hittaPlats);
            // 2. Parkera fordonet

            // Repetera fordonsparkering ett antal gånger

        }
    }
}
