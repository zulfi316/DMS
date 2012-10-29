using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UI.Session;
using BusinessLayer.BLDocket;

namespace UI.Docket
{
    public partial class Main : System.Web.UI.Page
    {
        public List<UIDocket.Docket> docketsForUser;
        protected void Page_Load(object sender, EventArgs e)
        {

            List<String[]> rawDocketInfo = BLDocketHelper.Instance.GetDocketsForUserId(SessionHelper.Instance.GetUserId());

            if (rawDocketInfo == null || rawDocketInfo.Count == 0)
                return;

            docketsForUser = new List<UIDocket.Docket>();

            foreach (string[] doceketInfo in rawDocketInfo)
            {
                UIDocket.Docket docket = new UIDocket.Docket(doceketInfo[0], doceketInfo[1], doceketInfo[2]);
                docketsForUser.Add(docket);
            }

            SessionHelper.Instance.SetDockets(docketsForUser.ToArray());
        }
    }
}