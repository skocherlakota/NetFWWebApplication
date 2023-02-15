using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NetFWWebApplication.Account
{
    public partial class AddNewBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GetBooks();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                lblMessage.Text = "Book title is missing";
            }
            else
            {
                SqlConnection cconnection = DBHelper.GetSqlConnection();
                try
                {
                    SqlCommand command;
                    string sql = string.Empty;
                    if (string.IsNullOrEmpty(txtBookID.Text))
                    {
                        sql = $"insert into T_Book values ('{txtTitle.Text}','{txtAuthor.Text}','{txtPubDate.Text}','{txtPrice.Text}',0)";
                    }
                    else
                    {
                        sql = $"update T_Book set title = '{txtTitle.Text}', author = '{txtAuthor.Text}', pubdate = '{txtPubDate.Text}', price = '{txtPrice.Text}' where bookID = '{txtBookID.Text}')";
                    }

                    command = new SqlCommand(sql, cconnection);
                    command.ExecuteNonQuery();
                    lblMessage.Text = "Book updated sucessfully";
                    cconnection.Close();
                    GetBooks();
                }
                catch (Exception ex)
                {
                    lblMessage.Text = ex.Message;
                    cconnection.Close();
                }
                finally
                {
                    cconnection.Close();
                }
            }
        }

        public void GetBooks()
        {
            SqlConnection cconnection = DBHelper.GetSqlConnection();
            try
            {
                SqlCommand command;
                string sql = $"select * from T_Book";
                command = new SqlCommand(sql, cconnection);
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                command.Dispose();
                gvBooks.DataSource = ds;
                gvBooks.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void gvBooks_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "selecttitle")
            {
                lblMessage.Text = Convert.ToString(e.CommandArgument.ToString());
                try
                {
                    SqlConnection cconnection = DBHelper.GetSqlConnection();
                    SqlCommand command;
                    string sql = $"select * from T_Book where BookId = {e.CommandArgument.ToString()}";
                    SqlDataReader dataReader;
                    command = new SqlCommand(sql, cconnection);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        txtBookID.Text = dataReader.GetValue(0).ToString();
                        txtTitle.Text = dataReader.GetValue(1).ToString();
                        txtAuthor.Text = dataReader.GetValue(2).ToString();
                        txtPubDate.Text = dataReader.GetValue(3).ToString();
                        txtPrice.Text = dataReader.GetValue(4).ToString();
                    }
                    dataReader.Close();
                    command.Dispose();
                    cconnection.Close();
                    btnDelete.Visible = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public void ClearForm()
        {
            txtBookID.Text = string.Empty;
            txtAuthor.Text = string.Empty;
            txtTitle.Text = string.Empty;
            txtPubDate.Text = string.Empty;
            txtPrice.Text = string.Empty;
            lblMessage.Text = string.Empty;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection cconnection = DBHelper.GetSqlConnection();
            try
            {
                SqlCommand command;
                string sql = string.Empty;
                sql = $"update T_Book set Del_IND = 1 where bookID = '{txtBookID.Text}'";
                command = new SqlCommand(sql, cconnection);
                command.ExecuteNonQuery();
                lblMessage.Text = "Book deleted sucessfully";
                cconnection.Close();
                GetBooks();
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
                cconnection.Close();
            }
            finally
            {
                cconnection.Close();
            }
        }
    }
}