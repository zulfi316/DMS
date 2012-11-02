using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace DataLayer.connection
{
    class DBconnection
    {
        private string constring;
        private SqlConnection con;
        public DBconnection()
        {
            constring = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            con = new SqlConnection();
            con.ConnectionString = constring;
           
            
         }
        public int open()
        {
            try
            {
                con.Open();
                return 1;
            }
            catch (SqlException ex)
            {

                return ex.ErrorCode;
            }
            
        }

        public int close()
        {
            try
            {
                con.Close();
                return 1;
            }
            catch (SqlException ex)
            {
                
                return ex.ErrorCode;
            }
        }
        


    }
}
