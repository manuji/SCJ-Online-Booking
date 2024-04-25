using System.Collections.Generic;
using SCJ.Booking.MVC.Utils;

namespace SCJ.Booking.MVC.ViewModels.SC
{
    public class ScBookingTypeViewModel
    {
        public ScBookingTypeViewModel()
        {
            //Default values
            HearingTypeId = -1;
            HearingTypeName = string.Empty;
            EstimatedTrialLength = null;
            IsHomeRegistry = null;
            IsLocationChangeFiled = null;
            TrialLocationRegistryId = -1;
        }

        //Booking type fields
        public int HearingTypeId { get; set; }
        public string HearingTypeName { get; set; }
        public int? EstimatedTrialLength { get; set; }
        public bool? IsHomeRegistry { get; set; }
        public bool? IsLocationChangeFiled { get; set; }
        public int TrialLocationRegistryId { get; set; }
        public List<string> AvailableBookingTypes { get; set; }

        // Session object
        public ScSessionBookingInfo SessionInfo { get; set; }
    }
}