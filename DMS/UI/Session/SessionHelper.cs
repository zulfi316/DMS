using System;
using System.Collections.Generic;
using System.Web;

namespace UI.Session
{
    public class SessionHelper
    {
        private Dictionary<string, SessionData> sessionInfo = new Dictionary<string, SessionData>();

        private static SessionHelper helper;
        private static object lockObject = new object();

        private const string SESSION_ID_TOKEN = "DMS.UId";

        private SessionHelper()
        {

        }

        public static SessionHelper Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (helper == null)
                        helper = new SessionHelper();

                    return helper;
                }
            }
        }


        public bool InitSession(UIUser.User userInfo)
        {
            //Check if data from last run still exists, if it does we remove it, it is now invalid
            if (sessionInfo.ContainsKey(userInfo.Id))
                sessionInfo.Remove(userInfo.Id);

            SessionData data = new SessionData();
            data.UserInfo = userInfo;

            HttpContext.Current.Session.Add(SESSION_ID_TOKEN, userInfo.Id);
            sessionInfo.Add(userInfo.Id, data);

            return true;
        }

        public string GetUserId()
        {
            return (sessionInfo[(string)HttpContext.Current.Session[SESSION_ID_TOKEN]]).UserInfo.Id;
        }
    }
}