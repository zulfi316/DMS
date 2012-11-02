using System;
using System.Collections.Generic;
using System.Web;
using System.Collections.Specialized;

namespace UI.ActionFactory.Actions
{
    public class SaveDocket : IAction
    {
        NameValueCollection arguments;
        public SaveDocket(NameValueCollection arguments)
        {

            this.arguments = arguments;
        }

        public string Execute()
        {
            UIDocket.Docket newDocket = new UIDocket.Docket(0, arguments["number"], arguments["inventionName"], arguments["inventorName"], arguments["appType"]);

            return newDocket.Save();
        }
    }
}