using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Library_Management
{
    public partial class Rerd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TempDAL dal = new TempDAL();
            lbl_Test.Text = dal.ConnectStr;
        }
    }
}