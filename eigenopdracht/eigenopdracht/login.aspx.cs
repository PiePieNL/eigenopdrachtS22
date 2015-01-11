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
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if(checkusename() == true)
            {
                if(checkpass()==true)
                {
                    Session["Username"] = txtUsername.Text;
                    Response.Redirect("Nieuws.aspx");
                   
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

        public bool checkusename()
        {
            bool userbestaat = false;
            OracleConnection conn = new OracleConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            int usernamecheck;
            try
            {
                conn.Open();
                OracleCommand oraCommand = new OracleCommand("SELECT count(*) as usercheck from ACCOUNT where username = :username", conn);
                oraCommand.Parameters.Add(new OracleParameter("username", txtUsername.Text));
                usernamecheck = int.Parse(oraCommand.ExecuteScalar().ToString());
                if( usernamecheck ==1)
                {
                    userbestaat = true;
                }

            }
            catch { }
            finally
            {
                conn.Close();
            }
            return userbestaat;
        }

        public bool checkpass()
        {
            bool passcorrect = false;
            OracleConnection conn = new OracleConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            try
            {
                conn.Open();
                OracleCommand oraCommand = new OracleCommand("SELECT wachtwoord  from ACCOUNT where username = :username", conn);
                oraCommand.Parameters.Add(new OracleParameter("username", txtUsername.Text));
                string password = oraCommand.ExecuteScalar().ToString();
                if (password == txtPassword.Text)
                {
                    passcorrect = true;
                }

            }
            catch { }
            finally
            {
                conn.Close();
            }
            return passcorrect;

        }

     
    }
}