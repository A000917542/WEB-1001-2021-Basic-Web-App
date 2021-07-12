using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_1001_2021_Basic_Web_App.Data
{
    public class Customer
    {
        [StringLength(64, MinimumLength = 5, ErrorMessage = "This needs to be longer.")]
        [Display(Name ="First Name", Description = "First or Given Name")]
        [Required(ErrorMessage = "First Name is Required", AllowEmptyStrings = false)]
        [RegularExpression("[A-Za-z]")]
        public string FirstName { get; set; }

        [StringLength(128, MinimumLength = 1)]
        [Display(Name = "Last Name", Description = "Last or Surname")]
        public string LastName { get; set; }

        [Key]
        [EmailAddress(ErrorMessage = "Please put in a correct Email address.")]
        public string Email { get; set; }

        public string Location { get; set; }

        public DateTime RegisterDate { get; set; }
    }
}
