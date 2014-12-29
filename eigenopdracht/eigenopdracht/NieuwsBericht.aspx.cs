using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace eigenopdracht
{
    public partial class NieuwsBericht : System.Web.UI.Page
    {
        DbBerichten db = new DbBerichten();
        Nbericht nieuws;
        protected void Page_Load(object sender, EventArgs e)
        {
           DbBerichten db = new DbBerichten();
            nieuws= db.GetNieuwsBericht(Request.Cookies["titelnieuws"].Value);
           Label1.Text = nieuws.Titel;
           Label2.Text = nieuws.Inhoud;
           Label3.Text = "postdatum: " + nieuws.Postdatum.ToString() + "laatst gewijzigd: " + nieuws.Laatstgewijzigd.ToString();
           Label4.Text = "bron: " + nieuws.Bron;
           Response.Cookies["BerichtId"].Value = nieuws.Berichtid.ToString();
           laadcomments();
           
            
        }

        protected void laadcomments()
        {
            Repeater1.DataSource = db.getReactiesBericht(nieuws.Berichtid);
            Repeater1.DataBind();
        }

        protected void btnAddComment_Click(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                string username = (string)(Session["Username"]);
                db.Plaatsreactie(new Reactie("Pieter12", txtComment.Text, nieuws.Berichtid));
            }
        }

       
        

       
    }
}