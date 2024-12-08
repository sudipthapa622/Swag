using System;
using System.ComponentModel.DataAnnotations;

namespace Swag.Models
{
    public class Roaster
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Employee name is required.")]
        [StringLength(100, ErrorMessage = "Employee name can't be longer than 100 characters.")]
        [Display(Name = "Employee Name")]
        public string EmployeeName { get; set; }

        [Required(ErrorMessage = "Start date is required.")]
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Start time is required.")]
        [Display(Name = "Start Time")]
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }

        [Required(ErrorMessage = "End date is required.")]
        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "End time is required.")]
        [Display(Name = "End Time")]
        [DataType(DataType.Time)]
        public DateTime EndTime { get; set; }

        [Required(ErrorMessage = "Role is required.")]
        [StringLength(100, ErrorMessage = "Role can't be longer than 100 characters.")]
        [Display(Name = "Role")]
        public string Role { get; set; }

        [Required(ErrorMessage = "Break start time is required.")]
        [Display(Name = "Break Start Time")]
        [DataType(DataType.Time)]
        public DateTime BreakStartTime { get; set; }

        [Required(ErrorMessage = "Break end time is required.")]
        [Display(Name = "Break End Time")]
        [DataType(DataType.Time)]
        public DateTime BreakEndTime { get; set; }
    }
}
