using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.connection;
using System.Xml;
using System.Data;
using System.Data.SqlClient;


namespace DataLayer.DLCountry
{
    public class DLcountryHelper
    {

        DBConnection dbManager;

        protected string getCountryInXml()
        {
            dbManager = new DBConnection();

            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = dbManager.Connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "[dbo].[get_country_list]";

                XmlReader reader = command.ExecuteXmlReader();

                DataSet ds = new DataSet();
                ds.ReadXml(reader);

                return ds.GetXml();
            }

            finally
            {
                dbManager.Close();
            }
        }
    }
}
