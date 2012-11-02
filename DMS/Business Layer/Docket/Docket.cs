using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.BLDocket
{
    public class Docket : DataLayer.DLDocket.Docket
    {

        public Docket()
        {

        }
        protected Docket(string docketNumber, string inventorId, string typeOfApp) : base(docketNumber, inventorId, typeOfApp)
        {
            
        }

        protected bool save()
        {
            
            
            //do the validation and the checks that need to be done here and call saveDocket function from base class
            return base.save();
        }

        protected string newDocketId()
        {
            //global variable which will hold current docket number. we will use this to get the new docket number here
            string newDocketNo = "";
            return newDocketNo;
        }
        


    }
}
