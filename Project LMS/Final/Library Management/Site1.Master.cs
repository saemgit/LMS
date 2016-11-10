using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library_Management
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToString(Session["login"]) == "yes")
            {
                LinkButton1.Text = "Log Out";              
            }          
        }

      

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            if (Convert.ToString(Session["login"]) == "yes")
            {
                Session.Clear();
                LinkButton1.Text = "Log Out";
                Response.Redirect("Home.aspx");
            }
            else
            {
                Session.Clear();
                Response.Redirect("Login.aspx");
            }
        }
    }
}