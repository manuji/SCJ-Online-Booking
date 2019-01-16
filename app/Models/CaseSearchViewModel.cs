using Microsoft.AspNetCore.Mvc.Rendering;
using SCJ.SC.OnlineBooking;
using System.ComponentModel.DataAnnotations;

namespace SCJ.Booking.MVC.Models
{
    public class CaseSearchViewModel
    {
        public CaseSearchViewModel()
        {
            Results = new AvailableDatesByLocation();
        }

        //Search fields
        [Required(ErrorMessage = "Please provide a Case Action Number.")]
        public string CaseNumber { get; set; }

        [Required(ErrorMessage = "Please choose the type of conference hearing.")]
        public Utils.Enums.ConferenceHearingType ConferenceType { get; set; }

        //Available dates
        public AvailableDatesByLocation Results { get; set; }

        //Indicator to show if there are results but no times available
        public bool NoAvailableTimes { get; set; }

        //Indicates if the case number is valid or not
        public bool IsValidCaseNumber { get; set; }

        //Indicates if the timeslot expired
        public bool TimeslotExpired { get; set; }

        //Location ID and Name
        public int SelectedRegistryId { get; set; }

        public string SelectedRegistryName { get; set; }

        [Required(ErrorMessage = "Please select the registry where the file was created.")]
        public SelectList Registry { get; set; }
    }
}