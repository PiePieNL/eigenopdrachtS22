using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eigenopdracht
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       
        protected void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string titel = ListView1.SelectedDataKey.Value.ToString();
            Response.Cookies["titelnieuws"].Value = titel;
            Response.Cookies["titelnieuws"].Expires = DateTime.Now.AddDays(1);
            Response.Redirect("NieuwsBericht.aspx");
        }


        

    }
}