using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NetFWWebApplication
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
        }       

        /// <summary>
        /// Test Comments for Git
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection cconnection = DBHelper.GetSqlConnection();
            try
            {                
                SqlCommand command;
                string sql = $"select * from users where active = 1 and username = '{txtUsername.Text.ToString()}' and password = '{txtPassword.Text.ToString()}'" ;
                SqlDataReader dataReader;
                command = new SqlCommand(sql, cconnection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    //MessageBox.Show(dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + " - " + dataReader.GetValue(2));
                    Session["username"] = dataReader.GetValue(0);                                 
                }
                dataReader.Close();
                command.Dispose();
                cconnection.Close();                
            }
            catch (Exception ex)
            {
                Response.Write("Can not open connection ! ");
                cconnection.Close();
            }
            finally
            {
                cconnection.Close();
            }

            if (Session["username"]!=null && !string.IsNullOrEmpty(Session["username"].ToString()))
            {
                Session["username"] = txtUsername.Text;
                SiteMaster siteMaster = new SiteMaster();
                siteMaster.UserName= txtUsername.Text;
                Response.Redirect("~/Account/Account.aspx", false);
            }
            else
            { 
                lblError.Text = "Details are wrong";
            }
        }
    }
}