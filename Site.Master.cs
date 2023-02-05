using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NetFWWebApplication
{
    public partial class SiteMaster : MasterPage
    {
        public string UserName { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            
            //if (Session["username"] == null)
            //{
            //    Response.Redirect("Login.aspx",true);
            //}
        }        
    }
}