using System;
using System.Collections.Generic;
using System.Web;

namespace UI.UICountry
{
    public class Country : BusinessLayer.BLCountry.Country
    {
        public Country(int id, string name, string shortName)
            : base(id, name, shortName)
        {

        }
    }
}