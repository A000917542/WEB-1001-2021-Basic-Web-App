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
    public class DatabaseModel : PageModel
    {
        StoreContext _context;

        [FromQuery]
        public Color color { get; set; }

        [FromForm]
        public Color updateColor { get; set; }

        public IList<Color> colorList { get; set; } = new List<Color>();

        public DatabaseModel(StoreContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            if (color.ShortCode != null)
            {
                _context.Colors.Add(color);
                _context.SaveChanges();
            }

            colorList = _context.Colors.ToList();
        }

        public void OnPost()
        {
            if(updateColor.ShortCode != null)
            {
                
                try
                {
                    _context.Colors.Update(updateColor);
                    _context.SaveChanges();
                }
                catch
                {
                    _context.Colors.Add(updateColor);
                    _context.SaveChanges();
                }
            }

            colorList = _context.Colors.ToList();
        }
    }
}
