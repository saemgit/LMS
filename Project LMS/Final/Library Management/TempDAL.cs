using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace Library_Management
{
    public class TempDAL
    {
        public string ConnectStr { get; set; }

        public TempDAL()
        {
            ConnectStr = ConfigurationManager.ConnectionStrings["LibraryDBConnectionString"].ToString();
        }
    }
}