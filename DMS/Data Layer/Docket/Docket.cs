using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.connection;
using System.Data.SqlClient;
using DataLayer.Properties;

namespace DataLayer.DLDocket
{
    public class Docket
    {
        private int id;
        private string number;
        private string inventorName;
        private string inventionName;
        private string typeOfApp;
        private DateTime createdOn;

        private DBConnection dbManager;

        protected Docket(int id, string number, string inventionName, string inventorId, string typeOfApp, DateTime createdOn)
        {
            this.id = id;
            this.number = number;
            this.inventorName = inventorId;
            this.typeOfApp = typeOfApp;
            this.inventionName = inventionName;
            this.createdOn = createdOn;
        }

        public String InventionName
        {
            get
            {
                return this.inventionName;
            }
        }

        public Int32 Id
        {
            get
            {
                return this.id;
            }
        }

        public String Number
        {
            get
            {
                return this.number;
            }
        }

        public String InventorName
        {
            get
            {
                return this.inventorName;
            }
        }

        public String TypeOfApp
        {
            get
            {
                return this.typeOfApp;
            }
        }

        protected bool Save()
        {
            SetCreatedOn();
            SetDocketNumber();

            try
            {
                dbManager = new DBConnection();
                dbManager.Open();

                SqlConnection connection = dbManager.Connection;

                SqlCommand command = new SqlCommand();

                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.CommandText = "[dbo].[save_docket]";
                command.Connection = connection;

                command.Parameters.AddWithValue("@invention_name", dbManager.CheckNull(this.inventionName));
                command.Parameters.AddWithValue("@inventor_name",  dbManager.CheckNull(this.inventorName));
                command.Parameters.AddWithValue("@type_of_app",    dbManager.CheckNull(this.typeOfApp));
                command.Parameters.AddWithValue("@number",         dbManager.CheckNull(this.number));
                command.Parameters.AddWithValue("@created_on",     dbManager.CheckNull(this.createdOn));

                Int32 docketId = Convert.ToInt32(command.ExecuteScalar());

                SetId(docketId);
                return true;
            }

            catch (SqlException ex)
            {
                //Make an entry in the log. Return false;
                throw;
            }
            finally
            {
                dbManager.Close();
            }


        }

        private void SetId(Int32 docketId)
        {
            this.id = docketId;
        }


        private void SetDocketNumber()
        {
            int docketNumber = GetLastDocketNumberFromDB();

            docketNumber++;

            this.number = Settings.Default.DocketNumberFormat.Replace("%YY%", DateTime.Now.ToString("yy")) +
                            Settings.Default.DocketNumberSeperator +
                                docketNumber.ToString("D" + Settings.Default.DocketNumberPadding);
        }

        private int GetLastDocketNumberFromDB()
        {
            // Get the number of the last inserted docket from the DB
            // the number will have a format of XXX-01, we get the int part of this
            // add one and return

            int docketNumber = 0;
            object returnValue;

            dbManager = new DBConnection();

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[get_last_docket_number]";

                cmd.Connection = dbManager.Connection;
                returnValue = cmd.ExecuteScalar();

            }
            finally
            {
                dbManager.Close();
            }

            // Incase there is nothing in the DB we get a nice null value here :)
            if (returnValue != null)
            {
                string numberOfLastInsertedDocket = returnValue.ToString();

                string[] lastDocketComponents = numberOfLastInsertedDocket.Split(Settings.Default.DocketNumberSeperator);

                // Check if the year part of the last inserted docket is the same as the current year, if not we have to return 0;
                string currentYear = DateTime.Now.ToString("yy");

                if (lastDocketComponents[0].Contains(currentYear))
                {
                    // oh ok, we already have entries for this year!
                    // Lets get the int part of this and return that

                    docketNumber = Convert.ToInt32(lastDocketComponents[lastDocketComponents.Length - 1]);
                }

            }

            // Either this will be a calculated value or zero
            return docketNumber;

        }

        private void SetCreatedOn()
        {
            this.createdOn = DateTime.Now;
        }


        protected bool Update()
        {
            return false;
        }


    }
}
