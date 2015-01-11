using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace eigenopdracht
{
    public partial class Top5 : System.Web.UI.Page
    {
        DbTop5 db = new DbTop5();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                FillddlJaar();
                LaadTop5DezeMaand();
            }
        }

        public void FillddlJaar()
        {
            List<int> jaren = new List<int>();
            int jaarnu = Convert.ToInt32(DateTime.Now.Year);
            for (int i = 0; i < 10; i++)
            {
                jaren.Add(jaarnu);
                jaarnu--;
            }
            ddlJaar.DataSource = jaren;
            ddlJaar.DataBind();
            
        }

        protected void ddlJaar_SelectedIndexChanged(object sender, EventArgs e)
        {
            LaadTop5(ddlJaar.SelectedValue, ddlmaand.SelectedValue);
        }

        protected void ddlmaand_SelectedIndexChanged(object sender, EventArgs e)
        {
            LaadTop5(ddlJaar.SelectedValue, ddlmaand.SelectedValue);
        }

        protected void LaadTop5(string jaar, string maand)
        {
            DataSet top5 = db.GetTop5(maand, jaar);
            rpGames.DataSource = top5;
            rpGames.DataBind();
        }
        protected void rpGames_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (rpGames.Items.Count < 1)
            {
                if (e.Item.ItemType == ListItemType.Footer)
                {
                    Label lblFooter = (Label)e.Item.FindControl("lblEmptyData");
                    lblFooter.Visible = true;
                }
            }
        }

        protected void LaadTop5DezeMaand()
        {
            string jaar = DateTime.Now.Year.ToString();
            string maand = "0";
            int maandtemp = DateTime.Now.Month; 
            if(maandtemp <10)
            {
                maand = maand + maandtemp.ToString();
            }
            else
            {
                maand = maandtemp.ToString();
            }
            LaadTop5(jaar, maand);
        }


       
            
    }
}