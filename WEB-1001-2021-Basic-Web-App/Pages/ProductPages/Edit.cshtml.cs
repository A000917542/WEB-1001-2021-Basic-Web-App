using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WEB_1001_2021_Basic_Web_App.Data;
using WEB_1001_2021_Basic_Web_App.Data.Context;

namespace WEB_1001_2021_Basic_Web_App.Pages.ProductPages
{
    public class EditModel : PageModel
    {
        private readonly WEB_1001_2021_Basic_Web_App.Data.Context.StoreContext _context;

        public EditModel(WEB_1001_2021_Basic_Web_App.Data.Context.StoreContext context)
        {
            _context = context;
        }

        [FromForm]
        public Product Product { get; set; }

        public IEnumerable<SelectListItem> Colors { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Products.FirstOrDefaultAsync(m => m.SKU == id);
            List<SelectListItem> colorList = _context.Colors.Select(
                color => new SelectListItem() {
                    Value = color.RGB
                    , Text = color.Name
                    , Selected = false }
                ).ToList();

            Colors = new List<SelectListItem>(colorList);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(Product Product2)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(Product.SKU))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ProductExists(string id)
        {
            return _context.Products.Any(e => e.SKU == id);
        }
    }
}
