using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemporaryTesting
{
    class Complaints
    {
        public string DateReceived;
        public string Product;
        public string SubProduct;
        public string Issue;
        public string SubIssue;
        public string Company;
        public string State;
        public int ZipCode;
        public string SubmittedVia;
        public string DateSent;
        public string CompanyResponse;
        public string TimelyResponse;
        public string ConsumerDisputed;
        public int ComplaintID;

        public Complaints(string DateReceived, string Product, string SubProduct, string Issue, string SubIssue, string Company, string State, int ZipCode, 
            string SubmittedVia, string DateSent, string CompanyResponse, string TimelyResponse, 
            string ConsumerDisputed, int ComplaintID)
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
        public override string ToString()
        {
            return $"Complaint Id : {ComplaintID}\t Product : {Product}";
        }

    }
}
