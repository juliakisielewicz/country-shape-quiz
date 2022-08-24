using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using QuizApp.Data;
using QuizApp.Models;
using Microsoft.AspNetCore.Identity;
using QuizApp.ViewModels;

namespace QuizApp.Pages
{
    [Authorize(Roles = "RegularUser, Administrator")]
    //[AllowAnonymous]
    public class IndexLoggedModel : PageModel
    {
        private readonly QuizApp.Data.QuizAppContext _context;

        public IndexLoggedModel(QuizApp.Data.QuizAppContext context)
        {
            _context = context;
        }

        //public IList<Country> Country { get; set; } = default!;
        public IList<Result> Results { get; set; } = default!;
        [BindProperty]
        public Result Result { get; set; } = default!;


        public async Task OnGetAsync()
        {
            //if (_context.Country != null)
           // {
           //     Country = await _context.Country.ToListAsync();
           // }

            if (_context.Result != null)
            {
                Results = await _context.Result.ToListAsync();
            }
        }



        public async Task<IActionResult> OnPostAsync()
        {
            foreach (var answer in _context.Result)
            {
                _context.Result.Remove(answer);
            }

            await _context.SaveChangesAsync();


            return RedirectToPage("./Quiz");
        }

    }
}
