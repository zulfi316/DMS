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

        public Docket()
        {

        }
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
            set
            {
                this.id = value;
            }
        }

        public String InventorName
        {
            get
            {
                return this.inventorName;
            }
            set
            {
                this.inventorName = value;
            }

        }

        public String TypeOfApp
        {
            get
            {
                return this.typeOfApp;
            }
            set
            {
              this.typeOfApp=value;
            }
        }

        protected bool save()
        {
            //Inser the docket into docket table.
            return false;
        }

        protected bool update()
        {
            //
            return false;
        }

       
    }
}
