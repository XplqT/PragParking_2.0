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
        public static void hittaLedigPRuta()
        {
            int i = 1;
            while (i <= antalRutor)
            {
                if (PRuta.Ledig(i) == true)
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
    }
}
