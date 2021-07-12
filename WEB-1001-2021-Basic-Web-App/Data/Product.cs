using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_1001_2021_Basic_Web_App.Data
{
    public class Product
    {
        [Key]
        public string SKU { get; set; }

        public string Name { get; set; }

        public string Decription { get; set; }

        public Decimal Price { get; set; }

        public string Category { get; set; }

        public string SubCategory { get; set; }

        public string Dimensions { get; set; }

        public ICollection<Color> Colors { get; set; }

        public ICollection<Material> Materials { get; set; }

        public ICollection<Media> Media { get; set; }
    }
}
