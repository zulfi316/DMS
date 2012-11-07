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
                                                            String.Empty, arguments["inventionName"],
                                                            arguments["inventorName"],
                                                            arguments["appType"],
                                                            DateTime.MinValue);

            string errorMessage;
            return JSONifyOutput(newDocket.Save(out errorMessage), errorMessage, newDocket.Number);
        }

        private string JSONifyOutput(bool success, string errorText, string docketNumber)
        {
            return           "{ " +
                                "\"success\": \"" + success.ToString() + "\", " +
                                "\"errorMessage\": \"" + errorText.Replace("'", "\\'") + "\", " +
                                "\"docketNumber\": \"" + docketNumber + "\"" +
                             " }";
        }
    }
}