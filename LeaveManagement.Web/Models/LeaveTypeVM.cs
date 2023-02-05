using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Required]

        [Display(Name = "Leave Type Name")]
        public string Name { get; set; }


        [Required]
        [Display(Name = " Number of Days")]
        //[Range(1,25 ErrorMessage = "See your manager.. ")]
        public int DefaultDays { get; set; }
    }
}
