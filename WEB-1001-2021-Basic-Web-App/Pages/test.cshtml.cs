using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WEB_1001_2021_Basic_Web_App.Pages
{
    public class testModel : PageModel
    {
        public void OnGet()
        {
        }

        [FromQuery(Name = "date")]
        public String date { get; set; }

        [FromQuery(Name = "color")]
        public string color { get; set; }
    }
}
