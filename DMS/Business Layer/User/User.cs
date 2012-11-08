using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.BLUser
{
    public class User : DataLayer.DLUser.User
    {
        protected User(string userName, string password) : base(userName, password)
        {
            
        }

        protected bool ValidateCredentials()
        {
            return base.ValidateCredentials();
        }
        
    }
}
