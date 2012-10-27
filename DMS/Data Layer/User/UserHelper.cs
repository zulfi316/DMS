using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.DLUser
{
    public class DLUserHelper
    {

        protected DLUserHelper()
        {

        }

        protected string[] GetUserInfoByUserName(string userName)
        {
            string[] userInfo = new string[2];

            userInfo[0] = "1";
            userInfo[1] = "Zulfi";


            return userInfo;
        }

    }
}
