﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UI.Session;
using BusinessLayer.BLUser;

namespace UI
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string userName = Request.Params["login.username"], password = Request.Params["login.password"];

            if (String.IsNullOrEmpty(userName) || String.IsNullOrEmpty(password))
                return;

            UIUser.User user = new UIUser.User(userName, password);

            user.ValidateCredentials();

            SessionHelper.Instance.InitSession(user);

            Response.Redirect("/Main.aspx");
        }
    }
}