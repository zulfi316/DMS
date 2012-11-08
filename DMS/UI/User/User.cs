using System;
using System.Collections.Generic;
using System.Text;

namespace UI.UIUser
{
    public class User : BusinessLayer.BLUser.User
    {
        public User(string userName, string password)
            : base(userName, password)
        {

        }


        public bool ValidateCredentials()
        {
            return base.ValidateCredentials();
        }
        
    }
}
