using System;

namespace PragParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vi behöver fordon, varför inte skapa en klass?");
            Fordon fordon = new Fordon();
            Console.WriteLine("Vi behöver ett fordon.");
            fordon.Regnr = "ABC123";
            Console.WriteLine($"Fordon: {fordon.Regnr}");
            Console.WriteLine("Nu vill vi parkera fordonet");
            PRuta pRuta = new PRuta();
            pRuta.Nummer = 1;
            pRuta.Ledig = true;
            Console.WriteLine($"Ruta {pRuta.Nummer} är ledig {pRuta.Ledig}");
            if (pRuta.Ledig = true)
            {
                pRuta.Regnr = fordon.Regnr;
                pRuta.Ledig = false;
            }
            Console.WriteLine($"Ruta {pRuta.Nummer} är ledig {pRuta.Ledig} där står {pRuta.Regnr}");
            fordon.Regnr = "DEF456";
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
        }
    }
}
