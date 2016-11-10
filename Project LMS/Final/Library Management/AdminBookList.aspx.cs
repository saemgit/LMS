using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace Library_Management
{
    public partial class AdminBookList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToString(Session["login"]) == "yes")
            {
                if (!IsPostBack)
                {

                    DAL d = new DAL();
                    DataTable dt = new DataTable();
                    dt = d.RetTable("Select ID,ShelfNo from tblShelfDetail");
                    ddl_shelf.DataTextField = "ShelfNo";
                    ddl_shelf.DataValueField = "ID";
                    ddl_shelf.DataSource = dt;
                    ddl_shelf.DataBind();
                    ddl_shelf.Items.Insert(0, new ListItem("Select", "NA"));



                    dt = d.RetTable("Select ID, DeptName from tblDepartmentName");
                    ddl_department.DataTextField = "DeptName";
                    ddl_department.DataValueField = "ID";
                    ddl_department.DataSource = dt;
                    ddl_department.DataBind();
                    ddl_department.Items.Insert(0, new ListItem("Select", "NA"));
                    LoadGrid();
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
        public void LoadGrid()
        {
            DAL d = new DAL();
            DataTable dt = new DataTable();
            dt = d.RetTable("select tblBookDetail.id,BookName,AuthorName,Publication,Price,DeptName,ShelfNo from tblBookDetail Left join tblShelfDetail on tblShelfDetail.ID=tblBookDetail.shelfId Left join tblDepartmentName on tblDepartmentName.ID=tblBookDetail.Department");
            grdBookList.DataSource = dt;
            grdBookList.DataBind();
        }
        protected void btn_signout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Login.aspx");
        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            string q = "INSERT INTO tblBookDetail (BookName,AuthorName,Publication,Price,Department,EntryBy,EntryTime,shelfId) VALUES ('" + txt_bookname.Text + "','" + txt_authorname.Text + "','" + txt_publication.Text + "','" + txt_price.Text + "','" + ddl_department.SelectedValue + "','" + Session["User"].ToString() + "',Getdate()," + ddl_shelf.SelectedValue + ")";
            DAL a = new DAL();
            int i = a.RetSave(q);
            if (i > 0)
            {
                ClearText();
                lbl_entrymsg.Text = "Successfully Saved.";
                LoadGrid();
            }
            else
            {
                lbl_entrymsg.Text = "Something went wrong";
            }
        }

        public void ClearText()
        {
            ddl_department.SelectedValue = "NA";
            ddl_shelf.SelectedValue = "NA";
            txt_authorname.Text = "";
            txt_bookname.Text = "";
            txt_publication.Text = "";
            txt_price.Text = "";
        }

        protected void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadGrid();
            ClearText();

        }

        protected void btn_search_Click(object sender, EventArgs e)
        {
            DAL s = new DAL();
            DataTable dt = new DataTable();
            dt = s.RetTable("select tblBookDetail.id,BookName,AuthorName,Publication,Price,DeptName,ShelfNo from tblBookDetail Left join tblShelfDetail on tblShelfDetail.ID=tblBookDetail.shelfId Left join tblDepartmentName on tblDepartmentName.ID=tblBookDetail.Department where BookName like '%" + txt_search.Text + "%'");
            grdBookList.DataSource = dt;
            grdBookList.DataBind();
        }


        protected void btnSelect_Click(object sender, EventArgs e)
        {
            int rowIndex = ((sender as Button).NamingContainer as GridViewRow).RowIndex;
            string id = Convert.ToString(grdBookList.DataKeys[rowIndex].Values[0]);
            DataTable dt = new DataTable();
            DAL dal = new DAL();
            dt = dal.RetTable("select id,BookName,AuthorName,Publication,Price,Department,ShelfID from tblBookDetail where id="+id);
            //ReTable is a Function
            txt_bookname.Text = dt.Rows[0]["BookName"].ToString(); 
            txt_authorname.Text = dt.Rows[0]["AuthorName"].ToString();
            txt_publication.Text = dt.Rows[0]["Publication"].ToString();
            txt_price.Text = dt.Rows[0]["Price"].ToString();
            ddl_department.SelectedValue = dt.Rows[0]["Department"].ToString();
            ddl_shelf.SelectedValue = dt.Rows[0]["ShelfID"].ToString();
        }

     }
}