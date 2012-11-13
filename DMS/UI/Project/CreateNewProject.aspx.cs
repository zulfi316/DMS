using System;
using System.Collections.Generic;
using BusinessLayer.BLCountry;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace UI.Project
{
    public partial class CreateNewProject : System.Web.UI.Page
    {
        public List<UICountry.Country> countryList;
        private BLcountryHelper countryHelper;

        protected void Page_Load(object sender, EventArgs e)
        {
            getCountryList();

        }

        public void getCountryList()
        {
            countryHelper = new BLcountryHelper();
            string rawCountryInfo = countryHelper.getCountryInXml();
            if (string.IsNullOrEmpty(rawCountryInfo) || rawCountryInfo.Trim().Equals(string.Empty))
                return;
            countryList = new List<UICountry.Country>();

            XmlDocument xCountryDoc = new XmlDocument();
            xCountryDoc.LoadXml(rawCountryInfo);

            XmlNodeList xCountryList = xCountryDoc.SelectNodes("//countries//country");

            foreach (XmlNode xNode in xCountryList)
            {
                int id;
                string name, shortName;

                id = Int32.Parse(xNode.SelectSingleNode("id").InnerText);
                
                name = xNode.SelectSingleNode("name").InnerText;
                shortName = xNode.SelectSingleNode("short_name").InnerText;

                UICountry.Country country = new UICountry.Country(id, name, shortName);
                countryList.Add(country);

            }
        }
    }
}