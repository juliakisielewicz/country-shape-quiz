using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using QuizApp.Data;
using QuizApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace QuizApp.Pages
{
    [Authorize(Roles ="RegularUser, Administrator")]
    public class QuizModel : PageModel
    {
        //private readonly SignInManager<IdentityUser> signInManager;
        //private readonly UserManager<IdentityUser> userManager;


        private readonly QuizApp.Data.QuizAppContext _context;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public QuizModel(QuizApp.Data.QuizAppContext context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IList<Country> Country { get; set; } = default!;
        public IList<Result> Results { get; set; } = default!;
        [BindProperty]
        public Result Result { get; set; } = default!;


        public async Task OnGetAsync()
        {
            if (_context.Country != null)
            {
                Country = await _context.Country.ToListAsync();
            }

            if (_context.Result != null)
            {
                Results = await _context.Result.ToListAsync();
            }
        }



        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Result == null || Result == null)
            {
                return Page();
            }

            var res = new Result()
            {
                id = Result.id,
                correct_answer = Result.correct_answer,
                selected_answer = Result.selected_answer,
                user_id = userManager.GetUserId(User)
            };
            /*
            if(signInManager.IsSignedIn(User))
            {
                Result.user_id = userManager.GetUserId(User);
            }
            */
            //Result.user_id = "tmp";
            _context.Result.Add(res);
            await _context.SaveChangesAsync();

            if (_context.Result.Where(c => c.user_id == userManager.GetUserId(User)).ToList().Count() >= 5)
            {
                return RedirectToPage("./Results");
            }

            return RedirectToPage("./Quiz");
        }

    }
}
