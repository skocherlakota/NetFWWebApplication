﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NetFWWebApplication
{
    public partial class User : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["username"] != null)
                {
                    //lblUserName.Text = Session["username"].ToString();
                }
                else
                {
                    Response.Redirect("~/Default.aspx");
                }
            }
        }

        protected void btnSignout_Click(object sender, EventArgs e)
        {
            Session["username"] = null;
            Response.Redirect("~/Default.aspx", false);
        }
    }
}