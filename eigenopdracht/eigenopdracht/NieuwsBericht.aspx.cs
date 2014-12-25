using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eigenopdracht
{
    public partial class NieuwsBericht : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           DbBerichten db = new DbBerichten();
           Nbericht nieuws= db.GetNieuwsBericht(Request.Cookies["titelnieuws"].Value);
           Label1.Text = nieuws.Titel;
           Label2.Text = nieuws.Inhoud;
           Label3.Text = "postdatum: " + nieuws.Postdatum.ToString() + "laatst gewijzigd: " + nieuws.Laatstgewijzigd.ToString();
           Response.Cookies["BerichtId"].Value = nieuws.Berichtid.ToString();
            
        }

       
        

       
    }
}