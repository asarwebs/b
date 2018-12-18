using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Configuration;

namespace cleaning.Models
{
    public class ConfirmationModel 
    {
        public DateTime ReportStart { get; private set; }
        public int? Amount { get; set; }
        public string Date { get; set; }
        public string Semail { get; set; }
        public string Sname { get; set; }

        //base constructor
        public ConfirmationModel(string sname, string semail, int? amount, string date)
        {
            this.Date = date;
            this.Sname = sname;
            this.Semail = semail;
            this.Amount = 100;
        }



    }
}