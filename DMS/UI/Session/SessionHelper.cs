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

        private SessionData sessionData
        {
            get
            {
                return sessionInfo[(string)HttpContext.Current.Session[SESSION_ID_TOKEN]];
            }
        }

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

            string id = userInfo.Id.ToString();
            if (sessionInfo.ContainsKey(id))
                sessionInfo.Remove(id);

            SessionData data = new SessionData();
            data.UserInfo = userInfo;

            HttpContext.Current.Session.Add(SESSION_ID_TOKEN, id);
            sessionInfo.Add(id, data);

            return true;
        }

        public string GetUserId()
        {
            return sessionData.UserInfo.Id.ToString();
        }

        public UIDocket.Docket[] GetDockets()
        {
            return sessionData.Dockets;
        }

        public bool SetDockets(UIDocket.Docket[] dockets)
        {
            sessionData.Dockets = dockets;
            return true;
        }

        public bool SetSelectedDocket(UIDocket.Docket docket)
        {
            UIDocket.Docket[] selectedDocketList = new UIDocket.Docket[1];
            selectedDocketList[0] = docket;

            UIDocket.Docket[] dockets = selectedDocketList;

            return true;

        }

        public UIDocket.Docket GetDocketById(int id)
        {
            foreach (UIDocket.Docket docket in sessionData.Dockets)
            {
                if (docket.Id == id)
                    return docket;
            }

            return null;
        }

        public UIDocket.Docket GetDocketById(string id)
        {
            return GetDocketById(Int32.Parse(id)); 
        }
    }
}