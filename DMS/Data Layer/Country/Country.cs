using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.DLCountry
{
    public class Country
    {
        private int id;
        private string name;
        private string shortName;

        protected Country(int id,string name,string shortName)
        {
            this.Id = id;
            this.Name = name;
            this.ShortName = shortName;
        }
        

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string ShortName
        {
            get { return this.shortName; }
            set { this.shortName = value; }
        }
    }
}
