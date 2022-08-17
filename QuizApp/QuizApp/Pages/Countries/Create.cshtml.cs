using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using QuizApp.Data;
using QuizApp.Models;

namespace QuizApp.Pages.Countries
{
    public class CreateModel : PageModel
    {
        private readonly QuizApp.Data.QuizAppContext _context;

        public CreateModel(QuizApp.Data.QuizAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Country Country { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        /*
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Country == null || Country == null)
            {
                return Page();
            }

            _context.Country.Add(Country);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }*/

        public string Name { get; set; }
        public void OnPostSubmit(Country cnt)
        {
            this.Name = string.Format("Name: {0} {1}", cnt.country_name, cnt.image_name);
        }
    }
}
