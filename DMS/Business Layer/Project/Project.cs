using System;
using System.Collections.Generic;
using System.Text;


namespace BusinessLayer.BLProject
{
    public class Project : DataLayer.DLProject.Project
    {
        protected Project(int id,BLDocket.Docket docket, string type, string number, string draftor, string invoiceNumber,string countryId)
            : base(id,docket, type, number, draftor, invoiceNumber,countryId)
        {
            
        }

        protected bool Save()
        {
            return base.save();
        }

       

    }
}
