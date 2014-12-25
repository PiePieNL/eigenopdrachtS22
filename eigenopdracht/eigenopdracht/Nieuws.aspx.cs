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

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string titelNieuws = GridView1.SelectedRow.Cells[1].Text;
            Response.Cookies["titelnieuws"].Value = titelNieuws;
            Response.Cookies["titelnieuws"].Expires = DateTime.Now.AddDays(1);
            Response.Redirect("NieuwsBericht.aspx");
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //e.Row.Cells[0].Attributes.Add("onClick", Label1.Text = GridView1.SelectedRow.Cells[1].Text);
            
           
        }


        

    }
}