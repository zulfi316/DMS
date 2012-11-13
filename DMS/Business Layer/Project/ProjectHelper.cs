using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.DLProject;

namespace BusinessLayer.BLProject
{
    public class BLProjectHelper : DataLayer.DLProject.DLProjectHelper
    {

        private static BLProjectHelper helper;
        private static object lockObject = new object();

        private BLProjectHelper()
        {

        }

        public static BLProjectHelper Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (helper == null)
                        helper = new BLProjectHelper();

                    return helper;
                }
            }
        }


        public List<string[]> GetProjectsForDocket(BLDocket.Docket docket)
        {
            return base.GetProjectsForDocket(docket);
        }

       
    }
}
