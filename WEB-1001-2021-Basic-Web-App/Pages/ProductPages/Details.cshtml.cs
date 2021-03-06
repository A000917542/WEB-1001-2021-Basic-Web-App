using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WEB_1001_2021_Basic_Web_App.Data;
using WEB_1001_2021_Basic_Web_App.Data.Context;

namespace WEB_1001_2021_Basic_Web_App.Pages.ProductPages
{
    public class DetailsModel : PageModel
    {
        private readonly WEB_1001_2021_Basic_Web_App.Data.Context.StoreContext _context;

        public DetailsModel(WEB_1001_2021_Basic_Web_App.Data.Context.StoreContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Products.FirstOrDefaultAsync(m => m.SKU == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
