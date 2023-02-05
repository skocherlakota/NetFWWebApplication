using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NetFWWebApplication.Account
{
    public partial class Account : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                if (Session["username"] != null)
                {
                    lblUserName.Text = Session["username"].ToString();
                }
                else
                {
                    Response.Redirect("~/Default.aspx");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Account/Details.aspx");
        }
    }
}