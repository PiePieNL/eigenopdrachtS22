using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eigenopdracht
{
    public class Reactie
    {
        private string username;
        private int berichtid;
        private string reactietekst;
        private DateTime postdatum;

        public string Username { get { return username; } }
        public int BerichtID { get { return berichtid; } }
        public string Reactietekst { get { return reactietekst; } }
        public DateTime Postdatum { get { return postdatum;} }


        public Reactie(string username,string reactietekst,DateTime postdatum)
        {
            this.postdatum = postdatum;
            this.reactietekst = reactietekst;
            this.username = username;
        }
    }
}