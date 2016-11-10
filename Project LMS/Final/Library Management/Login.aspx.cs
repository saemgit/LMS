using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library_Management
{
    public partial class Login : System.Web.UI.Page
    {
        public bool Logincheck()
        {
            string userid = txt_userid.Text;
            string password = txt_password.Text;
            string query = "select count(userid) from tblLogin where userid='" + userid + "' and password='" + password + "'";
            DAL d = new DAL();
            string i = d.RetString(query);

            if (Convert.ToInt16(i)>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_signin_Click(object sender, EventArgs e)
        {
            if (Logincheck())
            {
                Session["login"] = "yes";
                Session["User"] = txt_userid.Text;
                Response.Redirect("AdminBookList.aspx");
            }
            else
            {
                lbl_msg.Text = ("User ID or Password not matching!");
            }
        }

        protected void btn_cancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}