using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.BLUser
{
    public class BLUserHelper : DataLayer.DLUser.DLUserHelper
    {

        private static BLUserHelper helper;
        private static object lockObject = new object();

        private BLUserHelper()
        {

        }

        public static BLUserHelper Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (helper == null)
                        helper = new BLUserHelper();

                    return helper;
                }
            }
        }


        public new string[] GetUserInfoByUserName(string userName, string password)
        {
            //validate username, password
            return base.GetUserInfoByUserName(userName);
        }
    }
}
