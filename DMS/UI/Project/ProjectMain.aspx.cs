using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UI.Session;
using BusinessLayer.BLCountry;
using System.Xml;

namespace UI.Project
{
    public partial class ProjectMain : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            UIDocket.Docket selectedDocket = SetSelectedDocketInSession();

            //List<string[]> matchingProjects = BusinessLayer.BLProject.BLProjectHelper.Instance.GetProjectsForDocket(selectedDocket);

           
            //Create project objects :)
        }

        private UIDocket.Docket SetSelectedDocketInSession()
        {
            string selectedDocketId = Request.Params["DocketId"];

            UIDocket.Docket docket;

            docket = SessionHelper.Instance.GetDocketById(selectedDocketId);

            return docket;
        }

        

        
    }
}
