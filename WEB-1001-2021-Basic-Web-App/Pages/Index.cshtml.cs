using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_1001_2021_Basic_Web_App.Data;
using WEB_1001_2021_Basic_Web_App.Data.Context;

namespace WEB_1001_2021_Basic_Web_App.Pages
{
    public class ProductIndexModel : PageModel
    {
        private readonly ILogger<ProductIndexModel> _logger;
        private readonly StoreContext _dbContext;

        public ProductIndexModel(ILogger<ProductIndexModel> logger, StoreContext context)
        {
            _logger = logger;
            _dbContext = context;
        }



        public void OnGet()
        {
            // ViewData["Test"] = "This is a test";
            
            if (leftNumber > 0 && rightNumber > 0)
            {
                Result = leftNumber + rightNumber;
                ResultSet = true;
            }

            //Customer = _dbContext.Customers
            //    .Where(c => c.LastName == "Ritchie")
            //    .FirstOrDefault();

            //var newColor = new Color() { ShortCode = "DeepRed", Name = "DeepRed", RGB = "#FF0000" };
            //_dbContext.Add(newColor);
            //_dbContext.SaveChanges();

            //var cust = _dbContext.Customers
            //    .Where(c => c.LastName == "Ritchie");

            //Customer = cust.FirstOrDefault();
        }

        public void OnPost()
        {
            // string salt = String.Concat(LoginName, ":", LoginPass);
            if (ModelState.IsValid)
            {

            }

        }

        public HeroHeading heroData = new HeroHeading() { Heading = "test",  SubHeading = "test sub", ImageLink="Random image"};

        [FromForm]
        public Customer Customer { get; set; }

        [FromForm(Name = "loginName")]
        public string LoginName { get; set; }

        [FromForm(Name = "loginPass")]
        public string LoginPass { get; set; }

        [FromQuery(Name = "leftNumber")]
        public int leftNumber { get; set; }

        [FromQuery(Name = "rightNumber")]
        public int rightNumber { get; set; }

        public int Result { get; set; }

        public bool ResultSet { get; set; }
    }

    public class HeroHeading
    {
        public string ImageLink;
        public string Heading;
        public string SubHeading;
    }
}
