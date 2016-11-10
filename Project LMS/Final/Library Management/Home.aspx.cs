using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Library_Management
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_booklist_Click(object sender, EventArgs e)
        {
            DAL f = new DAL();
            DataTable dt = new DataTable();
            dt = f.RetTable("select * from tblBookDetail");
            grdhome.DataSource = dt;
            grdhome.DataBind();
        }

        protected void btn_homeSearch_Click(object sender, EventArgs e)
        {
            DAL s = new DAL();
            DataTable dt = new DataTable();
            dt = s.RetTable("select * from tblBookDetail where BookName like '%" + txt_homesearch.Text + "%'");
            grdhome.DataSource = dt;
            grdhome.DataBind();
        }

        protected void grdhome_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}