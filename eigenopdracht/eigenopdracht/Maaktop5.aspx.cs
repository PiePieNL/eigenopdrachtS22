using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace eigenopdracht
{
    public partial class Maaktop5 : System.Web.UI.Page
    {
        List<string>games = new List<string>();
        DbTop5 db = new DbTop5();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVoegGametoe_Click(object sender, EventArgs e)
        {
            bool succes = false;
            
            
                if (ListBox1.Items.Count == 0)
                {
                    succes = true;
                }
                else if (ListBox1.Items.Count <5)
                {
                    succes = checkDubbel(Listgames.SelectedValue);
                }
             
             if (succes == true)
             {
                 ListBox1.Items.Add(Listgames.SelectedValue);
             }
        }


        protected bool checkDubbel(string game)
        {
            bool succes = true;
            foreach (ListItem a in ListBox1.Items)
            {
                if (a.Value == Listgames.SelectedValue)
                {
                    succes = false;
                    return succes;
                }
            }
            return succes;
            
        }

        protected void btnverwijder_Click(object sender, EventArgs e)
        {
            if (ListBox1.SelectedIndex != -1)
            {
                ListBox1.Items.RemoveAt(ListBox1.SelectedIndex);
            }
        }

        protected void btmaaktop5_Click(object sender, EventArgs e)
        {
            string idtop5;
            int positie =1;
            if(ListBox1.Items.Count == 5)
            {
             if (db.Checktop5(ddlMaand.SelectedValue) == false)
                {
                   idtop5= db.PlaatsTop5(ddlMaand.SelectedValue);
                    foreach (ListItem a in ListBox1.Items)
                    {
                        string gameid = db.idgame(a.Value);
                        db.PlaatsTop5Postitie(gameid, idtop5, positie.ToString());
                        positie++;
                    }
                    Label1.Text = "top 5 gemaakt";
                    Label1.Visible = true;
                    Label1.ForeColor = Color.Green;
                    ListBox1.Items.Clear();
                }
             else
             {
                 Label1.Text = "Maand bestaat al";
                 Label1.Visible = true;
                 Label1.ForeColor = Color.Red;

             }


            }
            else
            {
                Label1.Text = "Plaats 5 games in top5 list";
                Label1.Visible = true;
                Label1.ForeColor = Color.Red;
            }
        }
    }
}