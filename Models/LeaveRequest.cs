using System;
using System.ComponentModel.DataAnnotations;

namespace Swag.Models
{
    public class LeaveRequest
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Start date is required.")]
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End date is required.")]
        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Reason for leave is required.")]
        [StringLength(500, ErrorMessage = "The reason cannot exceed 500 characters.")]
        [Display(Name = "Reason for Leave")]
        public string Reason { get; set; }
    }
}
