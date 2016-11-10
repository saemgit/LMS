using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Library_Management
{
    public class DAL
    {
        public string RetString(string query)
        {
            string returnValue = "";
            string connectionstring = ConfigurationManager.ConnectionStrings["LibraryDBConnectionString"].ToString();
            SqlConnection con = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.Text;
            try
            {
                con.Open();
                returnValue = Convert.ToString(cmd.ExecuteScalar());
            }
            catch (Exception)
            {
                con.Close();
            }
            finally
            {
                con.Close();
            }
            return returnValue;
        }
        public DataTable RetTable(string query)
        {
            DataTable dt = new DataTable();
            string connectionstring = ConfigurationManager.ConnectionStrings["LibraryDBConnectionString"].ToString();
            SqlConnection con = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.Text;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

            }
            catch (Exception)
            {
                con.Close();
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
        public int RetSave(string query)
        {
            int returnValue = 0;
            string connectionstring = ConfigurationManager.ConnectionStrings["LibraryDBConnectionString"].ToString();
            SqlConnection con = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.Text;
            try
            {
                con.Open();
                returnValue = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                con.Close();
            }
            finally
            {
                con.Close();
            }
            return returnValue;
        }


        internal void Fill(DataTable dt)
        {
            throw new NotImplementedException();
        }
    }
}