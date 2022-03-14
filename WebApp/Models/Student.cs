using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Display(Name = " FirstName")]
        [Required(ErrorMessage = "  FirstName can't Empty !")]
        public string FirstName { get; set; }
        [Display(Name = "LastName")]
        [Required(ErrorMessage = " LastName can't Empty !")]
        public string LastName { get; set; }
        [Display(Name = " Email Address")]
        [Required(ErrorMessage = " Email can't Empty !")]
        [EmailAddress(ErrorMessage = "Email Address is not valid !")]
        public string Email { get; set; }
        [Display(Name = " Mobile")]
        [Required(ErrorMessage = "Student Mobile can't Empty !")]
        [RegularExpression(@"^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$",
            ErrorMessage = "Invalid Mobile number !")]
        public string Mobile { get; set; }
        [Display(Name = "Gender")]
        [Required(ErrorMessage = " Gender can't Empty !")]
        public string Gender { get; set; }
    }
}
