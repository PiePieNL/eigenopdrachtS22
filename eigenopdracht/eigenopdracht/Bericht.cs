using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eigenopdracht
{
    public class Bericht
    {
       private int berichtid;
       private string titel;
       private string inhoud;
       private DateTime postdatum;
       private DateTime laatstgewijzigd;

       public int Berichtid { get { return berichtid; } }
       public string Titel { get { return titel; } }
       public string Inhoud { get { return inhoud; } }
       public DateTime Postdatum { get { return postdatum; } }
       public DateTime Laatstgewijzigd{ get { return laatstgewijzigd; } }



       public Bericht(int berichtid,string titel,string inhoud,DateTime postdatum,DateTime laatstgewijzigd)
       {
           this.berichtid = berichtid;
           this.titel = titel;
           this.inhoud = inhoud;
           this.postdatum = postdatum;
           this.laatstgewijzigd = laatstgewijzigd;
       }

       public Bericht(string titel)
       {
           this.titel = titel;
       }

    }
}