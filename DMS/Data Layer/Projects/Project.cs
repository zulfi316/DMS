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
        private string number;
        private string draftor;
        private string invoiceNumber;
        private int id;
        private string countryId;

        private DBConnection dbManager;

        protected Project(int id,DLDocket.Docket docket, string type, string number, string draftor, string invoiceNumber,string countryId)
        {
            this.Docket=docket;
            this.Type=type;
            this.Number=number;
            this.Draftor=draftor;
            this.InvoiceNumber=invoiceNumber;
            this.CountryId = countryId;
        }

        public DLDocket.Docket Docket
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

        public string Type
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

        public string Number
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

        public string Draftor
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

        public string InvoiceNumber
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

      
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        

        public string CountryId
        {           
            get { return this.countryId; }
            set { this.countryId = value; }
        }
        

        protected bool save()
        {
            try
            {

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
