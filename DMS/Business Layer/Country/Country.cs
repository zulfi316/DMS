using System;
using System.Collections.Generic;
using System.Text;


namespace BusinessLayer.BLCountry
{
    public class Country  : DataLayer.DLCountry.Country
    {
        protected Country(int id,string name,string shortName) : base(id,name,shortName)
        {

        }

    }
}
