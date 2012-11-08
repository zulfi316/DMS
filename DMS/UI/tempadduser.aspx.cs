using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class tempadduser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string uid, pwd, empId;

            uid = Request.Params["uid"];
            pwd = Request.Params["pass"];
            empId = Request.Params["eid"];

            if (string.IsNullOrEmpty(uid) || string.IsNullOrEmpty(pwd))
                return;

            DataLayer.DLUser.User.Save(uid, pwd, empId);

        }
    }
}