using System;
using System.Collections.Generic;
using System.Text;

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

        protected Project(DLDocket.Docket docket, string type, string id, string fileNumber, string draftor, string invoiceNumber)
        {

        }

        protected DLDocket.Docket Docket
        {
            get
            {
                return this.docket;
            }
        }

        protected string Type
        {
            get
            {
                return this.type;
            }
        }

        protected string Id
        {
            get
            {
                return this.id;
            }
        }

        protected string FileNumber
        {
            get
            {
                return this.fileNumber;
            }
        }

        protected string Draftor
        {
            get
            {
                return this.draftor;
            }
        }

        protected string InvoiceNumber
        {
            get
            {
                return this.invoiceNumber;
            }
        }
    }
}
