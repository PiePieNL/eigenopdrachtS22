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
    public partial class ZoekGame : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void ListView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            
            string titel = ListView1.SelectedDataKey.Value.ToString();
            Response.Cookies["gametitel"].Value = titel;
            Response.Cookies["gametitel"].Expires = DateTime.Now.AddDays(1);
            Response.Redirect("GameInfo.aspx");
        }

        

        protected void btnZoekGame_Click(object sender, EventArgs e)
        {
            if (txtZoekGame.Text == "")
            {
                lbwarning.Text = "voer het veld in!";
                lbwarning.Visible = true;
            }
            else if( SearchGame()== true)
            {
                Response.Cookies["gametitel"].Value = txtZoekGame.Text;
                Response.Cookies["gametitel"].Expires = DateTime.Now.AddDays(1);
                Response.Redirect("GameInfo.aspx");
            }
            else
            {
                lbwarning.Text = "game niet gevonden";
                lbwarning.Visible = true;
            }
        }


        public bool SearchGame()
        {
            bool gameFound = false;
            OracleConnection conn = new OracleConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            try
            {
                conn.Open();
                OracleCommand oraCommand = new OracleCommand("SELECT TITEL  from Game where UPPER(Titel) = UPPER(:Titel)", conn);
                oraCommand.Parameters.Add(new OracleParameter("Titel", txtZoekGame.Text));
                string gameTitel = oraCommand.ExecuteScalar().ToString();
                if (gameTitel != null)
                {
                    gameFound = true;
                }

            }
            catch { }
            finally
            {
                conn.Close();
            }
            return gameFound;
            
        }

        

        
    }
}