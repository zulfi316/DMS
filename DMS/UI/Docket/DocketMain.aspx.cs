using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UI.Session;
using BusinessLayer.BLDocket;
using System.Xml;

namespace UI.Docket
{
    public partial class Main : System.Web.UI.Page
    {
        public List<UIDocket.Docket> docketsForUser;
        protected void Page_Load(object sender, EventArgs e)
        {

            string rawDocketInfo = BLDocketHelper.Instance.GetDocketsForUserIdInXML(SessionHelper.Instance.GetUserId());

            if (String.IsNullOrEmpty(rawDocketInfo) || rawDocketInfo.Trim().Equals(string.Empty))
                return;

            docketsForUser = new List<UIDocket.Docket>();

            XmlDocument xDoc = new XmlDocument();
            xDoc.LoadXml(rawDocketInfo);

            XmlNodeList xList = xDoc.SelectNodes("//Dockets//Docket");

            foreach (XmlNode xNode in xList)
            {
                int id;
                string number, inventionName, inventorName, typeOfApp;

                id = Int32.Parse(xNode.SelectSingleNode("id").InnerText);
                number = xNode.SelectSingleNode("number").InnerText;
                inventionName = xNode.SelectSingleNode("invention_name").InnerText;
                inventorName = xNode.SelectSingleNode("inventor_name").InnerText;
                typeOfApp = xNode.SelectSingleNode("type_of_app").InnerText;

                UIDocket.Docket docket = new UIDocket.Docket(id, number, inventionName, inventorName, typeOfApp);
                docketsForUser.Add(docket);
            }

            SessionHelper.Instance.SetDockets(docketsForUser.ToArray());
        }
    }
}