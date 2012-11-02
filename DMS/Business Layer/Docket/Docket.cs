using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.BLDocket
{
    public class Docket : DataLayer.DLDocket.Docket
    {
        protected Docket(int id, string number, string inventionName, string inventorId, string typeOfApp)
            : base(id, number, inventionName, inventorId, typeOfApp)
        {

        }

        protected bool Save()
        {
            //do the validation and the checks that need to be done here and call saveDocket function from base class
            return base.Save();
        }
    }
}
