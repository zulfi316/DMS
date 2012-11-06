using System;
using System.Collections.Generic;
using System.Text;

namespace UI.UIDocket
{
    public class Docket : BusinessLayer.BLDocket.Docket
    {
        public Docket(int id, string number, string inventionName, string inventorId, string typeOfApp)
            : base(id, number, inventionName, inventorId, typeOfApp)
        {

        }

        public new String Save()
        {
            if (base.Save())
                return "yay!";
            else
                return "nain!";
        }
    }
}
