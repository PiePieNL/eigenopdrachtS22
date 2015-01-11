using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace eigenopdracht
{    
    public partial class GameInfo : System.Web.UI.Page
    {
        DbGame dbGame = new DbGame();
        protected void Page_Load(object sender, EventArgs e)
        {
            string gametitel = Request.Cookies["gametitel"].Value;
            DataSet ds = dbGame.GetGameInfo(gametitel);
            Repeater1.DataSource = ds;
            Repeater1.DataBind();
            Repeater2.DataSource = dbGame.getGameNieuws("");
            Repeater2.DataBind();
            LaadScreenShots(gametitel);
            
            
        }

        protected void LaadScreenShots(string gametitel)
        {
            mylist.DataSource = dbGame.Getscreenshots(gametitel);
            mylist.DataBind();
        }

       

       
       

       
    }
}