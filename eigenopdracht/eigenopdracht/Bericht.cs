using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eigenopdracht
{
   abstract public class Bericht
    {
       private string titel;
       private string inhoud;
       private DateTime postdatum;
       private DateTime laatstgewijzigd;
       private string platform;

       public string Titel { get { return titel; } }
       public string Inhoud { get { return inhoud; } }
       public DateTime Postdatum { get { return postdatum; } }
       public DateTime Laatstgewijzigd{ get { return laatstgewijzigd; } }



       public Bericht(string titel,string inhoud,DateTime postdatum,DateTime laatstgewijzigd)
       {
           this.titel = titel;
           this.inhoud = inhoud;
           this.postdatum = postdatum;
           this.laatstgewijzigd = laatstgewijzigd;
       }

    }
}