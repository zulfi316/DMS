using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DataLayer.Properties;
namespace DataLayer.connection
{
    class DBConnection
    {
        private string connectionString;
        private SqlConnection connection;

        public SqlConnection Connection
        {
            get
            {
                if (connection.State != ConnectionState.Open)
                    this.Open();

                return connection;
            }
        }

        public DBConnection()
        {
            connectionString = Settings.Default.ConnectionString;
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;
        }

        public int Open()
        {
            try
            {
                connection.Open();
                return 1;

            }
            catch (SqlException ex)
            {

                return ex.ErrorCode;
            }

        }

        public int Close()
        {
            if (connection != null && connection.State != ConnectionState.Closed)
            {
                try
                {
                    connection.Close();
                }
                catch (SqlException ex)
                {

                    return ex.ErrorCode;
                }
            }

            return 1;

        }

        public object CheckNull(object input)
        {
            if (input == null)
                return DBNull.Value;
            else
                return input;
        }

        public object CheckNull(string input)
        {
            if (String.IsNullOrEmpty(input) || input.Trim().Equals(string.Empty))
                return DBNull.Value;

            return input;
        }

    }
}
