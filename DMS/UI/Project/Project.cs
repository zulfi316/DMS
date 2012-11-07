using System;
using System.Collections.Generic;

namespace UI.UIProject
{
    public class Project : BusinessLayer.BLProject.Project
    {
        protected Project(UIDocket.Docket docket, string type, string id, string fileNumber, string draftor, string invoiceNumber)
            : base(docket, type, id, fileNumber, draftor, invoiceNumber)
        {

        }
    }
}