using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.BLDocket
{
    public class Docket : DataLayer.DLDocket.Docket
    {
        protected Docket(string docketNumber, string inventorId, string typeOfApp) : base(docketNumber, inventorId, typeOfApp)
        {
            
        }
    }
}
