using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DataLayer.connection;

namespace DataLayer.DLProject
{
    public class Project
    {

        private DLDocket.Docket docket;
        private string type;
        private string id;
        private string fileNumber;
        private string draftor;
        private string invoiceNumber;

        private DBConnection dbManager;

        protected Project(DLDocket.Docket docket, string type, string id, string fileNumber, string draftor, string invoiceNumber)
        {
            this.Docket=docket;
            this.Type=type;
            this.Id=id;
            this.FileNumber=fileNumber;
            this.Draftor=draftor;
            this.InvoiceNumber=invoiceNumber;

        }

        protected DLDocket.Docket Docket
        {
            get
            {
                return this.docket;
            }
            set
            {
                this.docket = value;
            }
        }

        protected string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        protected string Id
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

        protected string FileNumber
        {
            get
            {
                return this.fileNumber;
            }
            set 
            {
                this.fileNumber = value;
            }

        }

        protected string Draftor
        {
            get
            {
                return this.draftor;
            }
            set 
            {
                this.draftor = value;
            }
        }

        protected string InvoiceNumber
        {
            get
            {
                return this.invoiceNumber;
            }
            set
            {
                this.invoiceNumber = value;
            }
        }


        protected bool save()
        {
            try
            {
                dbManager = new DBConnection();
                SqlConnection connection = dbManager.Connection;
                SqlCommand command = new SqlCommand();

                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.CommandText = "";
                command.Connection = connection;

                

                return true;
            }
            catch (SqlException ex)
            {
                //Enter 
                return false;
            }
        }
    }
}
