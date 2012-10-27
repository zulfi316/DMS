using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Docket
{
    public class DLDocketHelper
    {

        protected DLDocketHelper()
        {

        }

        protected List<string[]> GetDocketsForUserId(string userId)
        {
            string[] individualDocketInfo = new string[3];
            List<string[]> docketInfo = new List<string[]>();

            individualDocketInfo[0] = "001";
            individualDocketInfo[1] = "AMK";
            individualDocketInfo[2] = "Crap";

            docketInfo.Add(individualDocketInfo);

            individualDocketInfo = new string[3];
            individualDocketInfo[0] = "002";
            individualDocketInfo[1] = "ZT";
            individualDocketInfo[2] = "Superb";

            docketInfo.Add(individualDocketInfo);

            individualDocketInfo = new string[3];
            individualDocketInfo[0] = "003";
            individualDocketInfo[1] = "GT";
            individualDocketInfo[2] = "Pirate";

            docketInfo.Add(individualDocketInfo);


            return docketInfo;
        }

    }
}
