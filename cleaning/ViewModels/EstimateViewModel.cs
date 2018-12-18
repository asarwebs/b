using System.Web.Configuration;

namespace cleaning.ViewModels
{
    public class EstimateViewModel 
    {
        public string Sname { get; set; }
        public int? Samount { get; set; }
        public string Semail { get; set; }
        public string Sphone { get; set; }
        public string StripePublishableKey { get; set; }
    
        ////base constructor
        public EstimateViewModel(string sname, string semail, string sphone, int? samount)
        {
            this.Sname = sname;
            this.Semail = semail;
            this.Sphone = sphone;
            this.Samount = samount;
            this.StripePublishableKey = "";

        }
        public EstimateViewModel()
        {
        }


    }
}