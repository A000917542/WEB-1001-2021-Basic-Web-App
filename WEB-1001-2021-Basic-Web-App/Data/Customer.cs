using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_1001_2021_Basic_Web_App.Data
{
    public class Customer
    {
        [MaxLength(5)]
        public string FirstName { get; set; }

        [MinLength(3)]
        public string LastName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public DateTime RegisterDate { get; set; }
    }
}
