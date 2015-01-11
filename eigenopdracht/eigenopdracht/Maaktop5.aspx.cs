using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eigenopdracht
{
    public partial class Maaktop5 : System.Web.UI.Page
    {
        List<string>games = new List<string>();
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
            if(ListBox1.Items.Count == 5)
            {
                foreach (ListItem a in ListBox1.Items)
                {
                    games.Add(a.Value);
                }

            }
        }
    }
}