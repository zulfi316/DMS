using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.DLProject
{
    public class DLProjectHelper
    {

        protected DLProjectHelper()
        {

        }

        protected List<string[]> GetProjectsForDocket(DLDocket.Docket docket)
        {
            string[] individualProjectInfo = new string[3];
            List<string[]> projectInfo = new List<string[]>();

            individualProjectInfo[0] = "001";
            individualProjectInfo[1] = "AMK";
            individualProjectInfo[2] = "Crap";

            projectInfo.Add(individualProjectInfo);

            individualProjectInfo = new string[3];
            individualProjectInfo[0] = "002";
            individualProjectInfo[1] = "ZT";
            individualProjectInfo[2] = "Superb";

            projectInfo.Add(individualProjectInfo);

            individualProjectInfo = new string[3];
            individualProjectInfo[0] = "003";
            individualProjectInfo[1] = "GT";
            individualProjectInfo[2] = "Pirate";

            projectInfo.Add(individualProjectInfo);


            return projectInfo;
        }

    }
}
