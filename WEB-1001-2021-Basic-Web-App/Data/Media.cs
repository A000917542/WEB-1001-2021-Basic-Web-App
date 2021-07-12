using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_1001_2021_Basic_Web_App.Data
{
    public class Media
    {
        public string Name { get; set; }
        
        [Key]
        public string FilePath { get; set; }
        public string FileType { get; set; }
        public string MediaDescriptor { get; set; }
    }
}
