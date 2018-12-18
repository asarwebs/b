using System.Web.Configuration;

namespace cleaning.ViewModels
{
    public class EstimateViewModel 
    {
        //public EndeavorDailyGridParameters Parameters { get; private set; }
        //public IEnumerable<EndeavorSched> Schedule { get; private set; }
        //public IEnumerable<EndeavorQH> QHSchedule { get; private set; }
        //public DateTime ReportStart { get; private set; }

        //public bool HasAveragesPopupAccess = false;

        //public bool HasPdf { get; set; }
        //public bool RenderAsPdf { get; set; }
        //public List<List<ResultHeaderItem>> ResultHeaders { get; set; }

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
            this.StripePublishableKey = "pk_test_MjdqtaiOSqvgcP1UDyxzNaDB";
            //this.Parameters = parameters;
            //this.ReportStart = reportStart;
        }
        public EstimateViewModel()
        {
        }

        //public EndeavorDailyGridViewModel(EndeavorDailyGridParameters parameters, IEnumerable<EndeavorSched> scheds, DateTime reportStart, bool hasMktAllAccess) : this(parameters, reportStart)
        //{
        //    this.Schedule = scheds;
        //    InitResultHeaders();
        //    this.HasAveragesPopupAccess = hasMktAllAccess;
        //}

        //public EndeavorDailyGridViewModel(EndeavorDailyGridParameters parameters, IEnumerable<EndeavorSched> scheds, IEnumerable<EndeavorQH> qhScheds, DateTime reportStart, bool hasMktAllAccess) : this(parameters, scheds, reportStart, hasMktAllAccess)
        //{
        //    this.QHSchedule = qhScheds;
        //    this.HasAveragesPopupAccess = hasMktAllAccess;
        //}

        //public int calculateColSpan(EndeavorSched show)
        //{
        //    int duration = (int)(show.EndDate - show.StartDate).TotalMinutes;
        //    int fromStart = (int)(show.EndDate - Parameters.StartDate).TotalMinutes;
        //    int fromEnd = (int)(Parameters.EndDate - show.StartDate).TotalMinutes;
        //    int window = 180;

        //    return Math.Min(Math.Min(duration, fromStart), Math.Min(fromEnd, window));
        //}

        //public void InitResultHeaders()
        //{
        //    var header1 = new List<ResultHeaderItem>(2);

        //    if (Parameters.MarketId == 0 && Parameters.StationId == 0)
        //    {
        //        if (Schedule.Any())
        //        {
        //            header1.Add(new ResultHeaderItem() { Display = "All Networks" + (Parameters.IsCable ? " (Cable)" : " (Broadcast)") });
        //            header1.Add(new ResultHeaderItem() { Display = "Average All Markets" });
        //        }
        //    }
        //    else if (Parameters.MarketId == 0)
        //    {
        //        if (Schedule.Any())
        //        {
        //            header1.Add(new ResultHeaderItem() { Display = Schedule.FirstOrDefault()?.CallSign });
        //            header1.Add(new ResultHeaderItem() { Display = "All Markets" });
        //        }
        //    }
        //    else if (Parameters.StationId == 0)
        //    {
        //        if (Schedule.Any())
        //        {
        //            header1.Add(new ResultHeaderItem() { Display = "All Networks" + (Parameters.IsCable ? " (Cable)" : " (Broadcast)") });
        //            header1.Add(new ResultHeaderItem() { Display = Schedule.FirstOrDefault()?.NielsenName });
        //        }
        //    }
        //    else
        //    {
        //        string affil = "";
        //        if (Schedule.Any())
        //        {
        //            affil = Schedule.FirstOrDefault()?.Affil;
        //            header1.Add(new ResultHeaderItem() { Display = Schedule.FirstOrDefault()?.CallSign + affil });
        //            header1.Add(new ResultHeaderItem() { Display = Schedule.FirstOrDefault()?.NielsenName });
        //        }

        //        if (!string.IsNullOrWhiteSpace(affil))
        //        {
        //            affil = $" ({affil})";
        //        }


        //    }

        //    List<ResultHeaderItem> header2 = new List<ResultHeaderItem>(1){
        //        new ResultHeaderItem() { Display = HeaderFormatter.FormatSliceString(Parameters.Demo, Parameters.ViewingType) }
        //    };

        //    List<ResultHeaderItem> header3 = new List<ResultHeaderItem>(1){
        //        new ResultHeaderItem() { Display = Parameters.StartDate.ToString(DateTimeExtensions.DISPLAY_SHORT_DAY_OF_WEEK) + ", " + Parameters.StartDate.ToString(DateTimeExtensions.DISPLAY_DATE_FORMAT_SHORT)}
        //    };

        //    ResultHeaders = new List<List<ResultHeaderItem>>() {
        //        header1,
        //        header2,
        //        header3
        //    };
        //}
    }
}