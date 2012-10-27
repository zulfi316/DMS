using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.DLUser
{
    public class User
    {
        private string id;
        private string name;

        protected User(string id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public String Id
        {
            get
            {
                return this.id;
            }
        }

        public String Name
        {
            get
            {
                return this.name;
            }
        }
    }
}
