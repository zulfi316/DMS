using System;
using System.Collections.Generic;
using System.Text;

namespace UI.UIDocket
{
    public class Docket : BusinessLayer.BLDocket.Docket
    {
        BusinessLayer.BLDocket.BLDocketHelper UIdocketHelp;
        public Docket()
        {
                
        }
        public Docket(string docketNumber, string inventorId, string typeOfApp) : base(docketNumber, inventorId, typeOfApp)
        {
            
        }

        public string createDocket()
        {
            string docketNumber = base.newDocketId();
            return docketNumber;
        }

        public new bool save()
        {
            return base.save();
            
        }

        public List<string[]> getDocketDetails(string docketNo)
        {
            return UIdocketHelp.getDocketDetail(docketNo);
        }
    }
}
