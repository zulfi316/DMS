using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UI.Session;

namespace UI.Project
{
    public partial class ProjectMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UIDocket.Docket selectedDocket = SetSelectedDocketInSession();
            List<string[]> matchingProjects = BusinessLayer.BLProject.BLProjectHelper.Instance.GetProjectsForDocket(selectedDocket);

            //Create project objects :)
        }

        private UIDocket.Docket SetSelectedDocketInSession()
        {
            string selectedDocketId = Request.Params["DocketId"];

            UIDocket.Docket[] docketList = SessionHelper.Instance.GetDockets();

            foreach (UIDocket.Docket docket in docketList)
            {
                if (docket.Id.Equals(selectedDocketId))
                {
                    SessionHelper.Instance.SetSelectedDocket(docket);
                    return docket;
                }
            }

            return null;
        }
    }
}