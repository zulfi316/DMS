using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using DataLayer.connection;
using System.Data.SqlClient;

namespace DataLayer.DLUser
{
    public class User
    {
        private string name;
        private string password;
        private int id;
        private string employeeId;

        protected User(string userName, string password)
        {
            this.name = userName;
            this.password = password;
        }

        public String Name
        {
            get
            {
                return this.name;
            }
        }

        public Int32 Id
        {
            get
            {
                return this.id;
            }
        }


        protected bool ValidateCredentials()
        {
            //We use SHA for encryption

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

            // First we encrypt the currently entered UID and password
            byte[] password = sha.ComputeHash(System.Text.Encoding.ASCII.GetBytes(this.password));

            // Then we get the password for this user from the DB
            // For this we are in a dilemma, did the user enter his login name or his employee id?
            // Thus the select from the DB will be where name = blah OR emplyoee_id = blah. 

            byte[] existingPassword = GetExistingPassword();

            try
            {
                if (ComparePassword(password, existingPassword))
                    this.Initialize();

            }
            catch
            {
                throw;
            }

            return true;
        }

        private void Initialize()
        {
            // Haha! Now we have the name populated with either the login id or emp id,
            // Just get the data and initialize the values and we are done!

            DBConnection dbManager = new DBConnection();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[get_user_details]";
                cmd.Parameters.AddWithValue("@id", dbManager.CheckNull(this.name));

                cmd.Connection = dbManager.Connection;

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader != null && reader.HasRows)
                {
                    while (reader.Read())
                    {
                        this.id = Convert.ToInt32(reader["id"]);
                        this.name = Convert.ToString(reader["login_name"]);
                        this.employeeId = Convert.ToString(reader["employee_id"]);
                        this.password = string.Empty;
                    }
                }
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

        private bool ComparePassword(byte[] password, byte[] existingPassword)
        {
            bool result = false;

            if (password != null && existingPassword != null)
            {
                if (password.Length == existingPassword.Length)
                {
                    result = true;
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (password[i] != existingPassword[i])
                        {
                            result = false;
                            break;
                        }
                    }
                }
            }

            return result;
        }


        // DO NOT USE THIS METHOD!
        public static bool Save(string uid, string pass, string eid)
        {
            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
            byte[] p = sha.ComputeHash(System.Text.Encoding.ASCII.GetBytes(pass));

            DBConnection dbManager = new DBConnection();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[add_user]";
                cmd.Parameters.AddWithValue("@login_name", dbManager.CheckNull(uid));
                cmd.Parameters.AddWithValue("@password", dbManager.CheckNull(p));
                cmd.Parameters.AddWithValue("@employee_id", dbManager.CheckNull(eid));

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

        private byte[] GetExistingPassword()
        {
            // Get the existing password from the DB;

            // there really is no need for this to be an instance variable. It is one select.
            DBConnection dbManager = new DBConnection();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[get_password]";
                cmd.Parameters.AddWithValue("@id", dbManager.CheckNull(this.name));
                cmd.Connection = dbManager.Connection;

                return (byte[])cmd.ExecuteScalar();

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
