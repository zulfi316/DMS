using System;
using System.Collections.Generic;
using System.Web;
using System.Collections.Specialized;
using UI.UIProject;

namespace UI.ActionFactory.Actions
{
    public class SaveProject : IAction
    {
        NameValueCollection arguments;

        public SaveProject(NameValueCollection arguments)
        {
            this.arguments = arguments;
        }

        public string Execute()
        {
            UIDocket.Docket docket = null;
           
            UIProject.Project newProject = new UIProject.Project(Int32.MinValue,docket, arguments["typeofProject"], string.Empty, arguments["drafter"], arguments["billing"],arguments["country"]);
            string errorMessage;

            Dictionary<string, string> jsonParameters = new Dictionary<string, string>();

            jsonParameters.Add("projectId", newProject.Number);
            jsonParameters.Add("docketId", newProject.Docket.Id.ToString());

            return Utilites.UtilityFunctions.JSONifyOutput(newProject.Save(out errorMessage), errorMessage, jsonParameters);                                     
        }

        
    }
}