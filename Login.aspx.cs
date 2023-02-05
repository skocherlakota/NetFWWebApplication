using System;
using System.Collections.Generic;
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

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals("sri") && txtPassword.Text.Equals("abc"))
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