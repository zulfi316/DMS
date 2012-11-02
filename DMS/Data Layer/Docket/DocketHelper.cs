using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DataLayer.DLDocket
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

        /// <summary>
        /// Function to retrieve details of a given docket number
        /// </summary>
        /// <param name="docketno">Docekt number should be provided</param>
        /// <returns>returns list of string containing the docket details</returns>
        protected List<string[]> getDocketDetail(string docketno)
        {
            //get connection set up and then get details from the database

            List<string[]> docketDetail = new List<string[]>();

            return docketDetail;
        }

    }
}
