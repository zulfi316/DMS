using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Docket
{
    public class BLDocketHelper : DataLayer.Docket.DLDocketHelper
    {

        private static BLDocketHelper helper;
        private static object lockObject = new object();

        private BLDocketHelper()
        {

        }

        public static BLDocketHelper Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (helper == null)
                        helper = new BLDocketHelper();

                    return helper;
                }
            }
        }


        public new List<string[]> GetDocketsForUserId(string userId)
        {
            return base.GetDocketsForUserId(userId);
        }
    }
}
