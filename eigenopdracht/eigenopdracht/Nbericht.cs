using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eigenopdracht
{
    public class Nbericht: Bericht
    {
        private string bron;
        public string Bron { get { return bron; } }

        public Nbericht(int berichtid,string titel, string inhoud, DateTime postdatum,DateTime laatstgewijzigd,string bron ): base(berichtid,titel,inhoud,postdatum,laatstgewijzigd)
        {
            this.bron = bron;
        }
    }
}