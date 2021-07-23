using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_1001_2021_Basic_Web_App.Data
{
    public class Color
    {
        public string ShortCode { get; set; }

        public string Name { get; set; }

        [Key]
        [StringLength(7, MinimumLength = 7)]
        [RegularExpression("^#[0-9A-Fa-f]{6}$")]
        [Required]
        public string RGB { get; set; }

        public ICollection<Media> Media { get; set; }
    }
}
