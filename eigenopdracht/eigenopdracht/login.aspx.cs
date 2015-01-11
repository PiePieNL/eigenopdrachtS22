using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace eigenopdracht
{
    public partial class login : System.Web.UI.Page
    { Dblogin dblogin = new Dblogin();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               HiddenFieldredirect.Value = Request.UrlReferrer.ToString();
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if(dblogin.checkusename(txtUsername.Text) == true)
            {
                if (dblogin.checkpass(txtUsername.Text,txtPassword.Text) == true)
                {
                    Session["Username"] = txtUsername.Text;
                    Response.Redirect(HiddenFieldredirect.Value);
                   
                }
                else
                {
                    lbErrormes.Text = "password incorrect";
                    lbErrormes.Visible = true;
                }
            }
            else
            {
                lbErrormes.Text = "Username incorect";
                lbErrormes.Visible = true;
            }

        }

       

     
    }
}