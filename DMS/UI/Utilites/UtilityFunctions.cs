using System;
using System.Collections.Generic;
using System.Web;
using System.Text;

namespace UI.Utilites
{
    public static class UtilityFunctions
    {
        public static string JSONifyOutput(bool success, string errorText, Dictionary<string, string> keyValuePairs)
        {

            StringBuilder json = new StringBuilder();

            json.Append("{ ");
            json.Append("\"success\": \"" + success.ToString() + "\", ");


            if (keyValuePairs != null)
            {
                json.Append("\"errorMessage\": \"" + errorText.Replace("'", "\\'") + "\", ");

                foreach (KeyValuePair<string, string> kVP in keyValuePairs)
                {
                    json.Append("\"" + kVP.Key + "\": \"" + kVP.Value + "\"");
                }
            }
            else
            {
                json.Append("\"errorMessage\": \"" + errorText.Replace("'", "\\'") + "\"");

            }


            json.Append(" }");

            return json.ToString();

        }

        public static string JSONifyOutput(bool success, string errorText)
        {
            return JSONifyOutput(success, errorText, null);
        }
    }
}