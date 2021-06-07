using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_1001_2021_Basic_Web_App.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }



        public void OnGet()
        {
            // ViewData["Test"] = "This is a test";
            
            if (leftNumber > 0 && rightNumber > 0)
            {
                Result = leftNumber + rightNumber;
                ResultSet = true;
            }
        }

        [FromQuery(Name = "leftNumber")]
        public int leftNumber { get; set; }

        [FromQuery(Name = "rightNumber")]
        public int rightNumber { get; set; }

        public int Result { get; set; }

        public bool ResultSet { get; set; }
    }
}
