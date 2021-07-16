using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WEB_1001_2021_Basic_Web_App.Data;
using WEB_1001_2021_Basic_Web_App.Data.Context;

namespace WEB_1001_2021_Basic_Web_App.Pages
{
    public class ColorDeleteModel : PageModel
    {
        StoreContext _context;

        [FromForm]
        public Color updateColor { get; set; }

        public ColorDeleteModel (StoreContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }

        public RedirectToPageResult OnPost()
        {
            if (updateColor.RGB != null)
            {
                _context.Colors.Remove(updateColor);
                _context.SaveChanges();
            }

            return new RedirectToPageResult("Database");
        }
    }
}
