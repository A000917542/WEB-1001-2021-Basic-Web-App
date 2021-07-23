using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEB_1001_2021_Basic_Web_App.Data;
using WEB_1001_2021_Basic_Web_App.Data.Context;

namespace WEB_1001_2021_Basic_Web_App.Pages.ProductPages
{
    public class CreateModel : PageModel
    {
        private readonly WEB_1001_2021_Basic_Web_App.Data.Context.StoreContext _context;

        public CreateModel(WEB_1001_2021_Basic_Web_App.Data.Context.StoreContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Products.Add(Product);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
