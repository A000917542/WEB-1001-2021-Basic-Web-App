using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_1001_2021_Basic_Web_App.Data
{
    public class Material
    {
        [Key]
        public string ShortCode { get; set; }

        public string Name { get; set; }

        public ICollection<Media> Media { get; set; }
    }
}
