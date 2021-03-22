using System;
using System.Collections.Generic;
using System.Text;

namespace PragParking
{
    class PRuta
    {
        private int nummer;
        private bool ledig;
        private string regnr;
        public int Nummer
        {
            get
            {
                return this.nummer;
            }
            set
            {
                this.nummer = value;
            }

        }
        public bool Ledig
        {
            get
            {
                return this.ledig;
            }
            set
            {
                this.ledig = value;
            }
        }
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
