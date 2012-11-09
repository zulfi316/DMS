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
            UIDocket.Docket newDocket = new UIDocket.Docket(Int32.MinValue,
                                                            String.Empty, 
                                                            arguments["inventionName"],
                                                            arguments["inventorName"],
                                                            arguments["appType"],
                                                            DateTime.MinValue);

            string errorMessage;

            Dictionary<string, string> jsonParameters = new Dictionary<string, string>();

            bool success = newDocket.Save(out errorMessage);
            jsonParameters.Add("docketId", newDocket.Number);

            return Utilites.UtilityFunctions.JSONifyOutput(success, errorMessage, jsonParameters);
        }

       
    }
}