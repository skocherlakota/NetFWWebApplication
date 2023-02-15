using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace NetFWWebApplication
{
    public static class DBHelper
    {
        public static SqlConnection GetSqlConnection()
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = ConfigurationManager.ConnectionStrings["LibraryCon"].ConnectionString;
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                return cnn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}