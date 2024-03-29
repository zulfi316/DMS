﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DataLayer.Properties;
using DataLayer.connection;
using System.Data.SqlClient;
using System.Xml;

namespace DataLayer.DLDocket
{
    public class DLDocketHelper
    {

        private DBConnection dbManager;

        protected DLDocketHelper()
        {

        }

        protected string GetDocketsForUserIdInXML(string userId)
        {
            dbManager = new DBConnection();

            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = dbManager.Connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "[dbo].[get_dockets_for_user]";

                command.Parameters.AddWithValue("@user_id", userId);

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

        /// <summary>
        /// Function to retrieve details of a given docket number
        /// </summary>
        /// <param name="docketno">Docekt number should be provided</param>
        /// <returns>returns list of string containing the docket details</returns>
        protected List<string[]> getDocketDetail(string docketno)
        {
            //get connection set up and then get details from the database

            List<string[]> docketDetail = new List<string[]>();

            return docketDetail;
        }

    }
}
