using System;
using System.Collections.Generic;
using System.Text;
using User.CryptoHelper;
using DataLayer.connection;
using System.Data.SqlClient;

namespace DataLayer.DLUser
{
    public class DLUserHelper
    {

        protected DLUserHelper()
        {

        }

        protected bool Save(string userName, string password, string employeeId)
        {
            byte[] p = CryptoHelper.Instance.EncryptStringToBytes(password);

            DBConnection dbManager = new DBConnection();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[add_user]";
                cmd.Parameters.AddWithValue("@login_name", dbManager.CheckNull(userName));
                cmd.Parameters.AddWithValue("@password", dbManager.CheckNull(p));
                cmd.Parameters.AddWithValue("@employee_id", dbManager.CheckNull(employeeId));

                cmd.Connection = dbManager.Connection;

                cmd.ExecuteNonQuery();

                return true;

            }
            catch
            {
                throw;
            }
            finally
            {
                dbManager.Close();
            }

        }


    }
}
