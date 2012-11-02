using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.BLDocket
{
    public class BLDocketHelper : DataLayer.DLDocket.DLDocketHelper
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

        /// <summary>
        /// function to get single docket detail
        /// </summary>
        /// <param name="docketNo"></param>
        /// <returns>return list of string as output</returns>
        public new List<string[]> getDocketDetail(string docketNo)
        {
            return base.getDocketDetail(docketNo);
        }


    }
}
