using System;
using System.Collections.Generic;
using BusinessLayer.BLProject;

namespace UI.UIProject
{
    public class Project : BusinessLayer.BLProject.Project
    {

        public Project(int id,UIDocket.Docket docket, string type, string number, string draftor, string invoiceNumber,string countryId)
            : base(id,docket, type, number, draftor, invoiceNumber,countryId)
        {

        }



       
            public bool Save(out string errorText)
        {
            errorText = string.Empty;

            try
            {
                return base.Save();
            }
            catch (Exception e)
            {
                errorText = e.Message + Environment.NewLine + e.StackTrace;
                return false;
            }
        }
        
    }
}