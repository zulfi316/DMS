using System;
using System.Collections.Generic;
using System.Web;

namespace UI.Session
{
    public class SessionData
    {
        private UIUser.User userInfo;

        public UIUser.User UserInfo
        {
            set
            {
                this.userInfo = value;
            }

            get
            {
                return this.userInfo;
            }
        }
    }
}