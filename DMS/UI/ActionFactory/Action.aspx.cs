using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.ActionFactory
{
    public partial class Action : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            IAction action = ActionFactory.GetAction(Request.Params);
            
            Response.Write(action.Execute());
        }
    }
}