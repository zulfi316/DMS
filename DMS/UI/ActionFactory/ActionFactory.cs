using System;
using System.Collections.Generic;
using System.Web;
using UI.ActionFactory.Actions;
using System.Collections.Specialized;

namespace UI.ActionFactory
{
    public class ActionFactory
    {
        public static IAction GetAction(NameValueCollection arguments)
        {
            string actionKey = arguments["actionKey"];

            switch (actionKey)
            {
                case "SaveDocket": return new SaveDocket(arguments);
                case "DeactivateDocket": return new DeactivateDocket(arguments);
                default:
                    return null;
            }
        }
    }
}