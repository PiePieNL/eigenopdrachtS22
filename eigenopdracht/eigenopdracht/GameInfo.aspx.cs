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
            DataSet ds = dbGame.GetGameInfo("Halo");
            Repeater1.DataSource = ds;
            Repeater1.DataBind();
           
            
            
        }

       

       
       

       
    }
}