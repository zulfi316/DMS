using System;
using System.Collections.Generic;
using System.Text;

namespace UI.UIDocket
{
    public class Docket : BusinessLayer.BLDocket.Docket
    {
        public Docket(int id, string number, string inventionName, string inventorId, string typeOfApp, DateTime createdOn)
            : base(id, number, inventionName, inventorId, typeOfApp, createdOn)
        {

        }

        public bool Save(out string errorText)
        {
            errorText = string.Empty;

            try
            {
                return base.Save();
            }
            catch(Exception e)
            {
                errorText = e.Message + Environment.NewLine + e.StackTrace;
                return false;
            }
        }
    }
}
