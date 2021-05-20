using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{
    class Complaint
    {
        public string DateReceived { get; set; }
        public string Product { get; set; }
        public string SubProduct { get; set; }
        public string Issue { get; set; }
        public string SubIssue { get; set; }
        public string Company { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string SubmittedVia { get; set; }
        public string DateSent { get; set; }
        public string CompanyResponse { get; set; }
        public string TimelyResponse { get; set; }
        public string ConsumerDisputed { get; set; }
        public string ComplaintID { get; set; }

        public Complaint(string DateReceived, string Product, string SubProduct, string Issue, string SubIssue, string Company, string State, string ZipCode,
            string SubmittedVia, string DateSent, string CompanyResponse, string TimelyResponse,
            string ConsumerDisputed, string ComplaintID)
        {
            this.DateReceived = DateReceived;
            this.Product = Product;
            this.SubProduct = SubProduct;
            this.Issue = Issue;
            this.SubIssue = SubIssue;
            this.Company = Company;
            this.State = State;
            this.ZipCode = ZipCode;
            this.SubmittedVia = SubmittedVia;
            this.DateSent = DateSent;
            this.CompanyResponse = CompanyResponse;
            this.TimelyResponse = TimelyResponse;
            this.ConsumerDisputed = ConsumerDisputed;
            this.TimelyResponse = TimelyResponse;
            this.ConsumerDisputed = ConsumerDisputed;
            this.ComplaintID = ComplaintID;
        }
    }
}
