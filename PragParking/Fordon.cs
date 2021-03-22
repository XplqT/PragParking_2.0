using System;
using System.Collections.Generic;
using System.Text;


namespace PragParking
{
    public class Fordon
    {
        private string regnr;

        public string Regnr
        {
            get
            {
                return this.regnr;
            }
            set
            {
                this.regnr = value;
            }
        }
    }
}
