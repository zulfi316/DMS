using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.connection;
using System.Data.SqlClient;

namespace DataLayer.DLDocket
{
    public class Docket
    {
        private int id;
        private string number;
        private string inventorName;
        private string inventionName;
        private string typeOfApp;

        private DBConnection dbManager;

        protected Docket(int id, string docketNumber, string inventionName, string inventorId, string typeOfApp)
        {
            this.id = id;
            this.number = docketNumber;
            this.inventorName = inventorId;
            this.typeOfApp = typeOfApp;
            this.inventionName = inventionName;
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
            set
            {
                this.id = value;
            }
        }

        public String Number
        {
            get
            {
                return this.number;
            }
            set
            {
                this.number = value;
            }
        }

        public String InventorName
        {
            get
            {
                return this.inventorName;
            }
            set
            {
                this.inventorName = value;
            }

        }

        public String TypeOfApp
        {
            get
            {
                return this.typeOfApp;
            }
            set
            {
                this.typeOfApp = value;
            }
        }

        protected bool Save()
        {

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

                Int32 docketId = Convert.ToInt32(command.ExecuteScalar());

                this.id = docketId;
                return true;
            }
            finally
            {
                dbManager.Close();
            }
        }

        protected bool Update()
        {
            return false;
        }


    }
}
