using System;
using System.Collections.Generic;
using System.Text;

namespace UI.UIDocket
{
    public class Docket : BusinessLayer.BLDocket.Docket
    {
        public Docket(string docketNumber, string inventorId, string typeOfApp) : base(docketNumber, inventorId, typeOfApp)
        {
            
        }
    }
}
