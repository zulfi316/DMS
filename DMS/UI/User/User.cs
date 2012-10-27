using System;
using System.Collections.Generic;
using System.Text;

namespace UI.UIUser
{
    public class User : BusinessLayer.BLUser.User
    {
        public User(string id, string name)
            : base(id, name)
        {

        }
    }
}
