using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.BLUser
{
    public class User : DataLayer.DLUser.User
    {
        protected User(string id, string name) : base(id, name)
        {
            
        }

        
    }
}
