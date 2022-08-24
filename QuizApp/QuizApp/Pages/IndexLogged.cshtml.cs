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
    public class IndexLoggedModel : PageModel
    {
        private readonly QuizApp.Data.QuizAppContext _context;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public IndexLoggedModel(QuizApp.Data.QuizAppContext context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IList<Result> Results { get; set; } = default!;
        [BindProperty]
        public Result Result { get; set; } = default!;


        public async Task OnGetAsync()
        {
            if (_context.Result != null)
            {
                Results = await _context.Result.ToListAsync();
            }
        }



        public async Task<IActionResult> OnPostAsync()
        {
            var uId = userManager.GetUserId(User);
            var userResults = _context.Result.Where(c => c.user_id == uId).ToList();
            if(userResults != null)
            {
                foreach (var answer in userResults)
                {
                    _context.Result.Remove(answer);
                }
            }

            await _context.SaveChangesAsync();

            return RedirectToPage("./Quiz");
        }

    }
}
