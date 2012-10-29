using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.BLProject
{
    public class Project : DataLayer.DLProject.Project
    {
        protected Project(BLDocket.Docket docket, string type, string id, string fileNumber, string draftor, string invoiceNumber)
            : base(docket, type, id, fileNumber, draftor, invoiceNumber)
        {
            
        }

    }
}
