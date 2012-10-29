using System;
using System.Collections.Generic;
using System.Web;

namespace UI.Session
{
    public class SessionData
    {
        private UIUser.User userInfo;
        private UIDocket.Docket[] dockets;

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

        public UIDocket.Docket[] Dockets
        {
            set
            {
                this.dockets = value;
            }
            get
            {
                return this.dockets;
            }
        }

        public UIDocket.Docket CurrentDocket
        {
            get
            {
                return this.dockets[0];
            }
        }
    }
}