using System;
using System.Collections.Generic;
using System.Web;
using System.Collections.Specialized;
using UI.Session;

namespace UI.ActionFactory.Actions
{
    public class DeactivateDocket : IAction
    {
        NameValueCollection arguments;

        public DeactivateDocket(NameValueCollection arguments)
        {

            this.arguments = arguments;
        }

        public string Execute()
        {
            string deactivationReason = this.arguments["reason"];
            bool deleted = Boolean.Parse(this.arguments["deleted"]);

            // pessimistic
            bool success = false;

            // this list will be | seperated, these will be only ints so we are ok here :)
            string[] docketIds = this.arguments["docketIds"].Split('|');
            string errorText = "Invalid selection!";

            foreach (string docketId in docketIds)
            {
                UIDocket.Docket docket = SessionHelper.Instance.GetDocketById(docketId);
                switch (deactivationReason)
                {
                    case "DELETE":
                        success = docket.SetDelete(deleted, out errorText);
                        break;
                }

            }


            return Utilites.UtilityFunctions.JSONifyOutput(success, errorText);
        }
    }
}