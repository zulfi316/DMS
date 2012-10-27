using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DMS
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string userName = Request.Params["login.userid"];
            string password = Request.Params["login.password"];
            string action = Request.Params["login.action"];

            if (String.IsNullOrEmpty(userName) || String.IsNullOrEmpty(password) || String.IsNullOrEmpty(action))
                return;

            //if(Global.BL.CompleteLogin(userName, password, out nextPage)) 

            if (action.Equals("Login!"))
                Server.Transfer("/UI/Main.aspx", false);
        }
    }
}