using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.DLDocket
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

        public String Id
        {
            get
            {
                return this.id;
            }
        }

        public String InventorName
        {
            get
            {
                return this.inventorName;
            }
        }

        public String TypeOfApp
        {
            get
            {
                return this.typeOfApp;
            }
        }
       
    }
}
