using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Docket
{
    public class Docket
    {
        private string id;
        private string inventorName;
        private string typeOfApp;

        protected Docket(string docketNumber, string inventorId, string typeOfApp)
        {
            this.id = docketNumber;
            this.inventorName = inventorId;
            this.typeOfApp = typeOfApp;
        }

       
    }
}
