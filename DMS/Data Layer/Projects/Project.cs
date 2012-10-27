using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Projects
{
    public class Project
    {
        private string type;
        private string id;
        private string fileNumber;
        private string draftor;
        private string invoiceNumber;
        private Docket.Docket docket;

        protected Project(string docketNumber, string inventorId, string typeOfApp)
        {

        }
    }
}
