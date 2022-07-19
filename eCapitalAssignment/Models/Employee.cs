using System.ComponentModel.DataAnnotations;

namespace eCapitalAssignment.Models
{
    #nullable disable
    public class Employee
    {
        public int Id { get; set; }
        [StringLength(200)]
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "{0} is required.")]
        public string FirstName { get; set; }
        [StringLength(200)]
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "{0} is required.")]
        public string LastName { get; set; }
        [DisplayFormat(DataFormatString = "{0:C0}")]
        [Required(ErrorMessage = "{0} is required.")]
        public int Salary { get; set; }
    }
}
