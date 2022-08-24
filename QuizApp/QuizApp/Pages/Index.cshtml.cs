using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuizApp.Data;
using QuizApp.Models;

namespace QuizApp.Pages
{
    [AllowAnonymous]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly QuizAppContext _context;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public IndexModel(ILogger<IndexModel> logger, QuizApp.Data.QuizAppContext context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signManager)
        {
            _logger = logger;
            this._context = context;
            this.userManager = userManager;
            this.signInManager = signManager;
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
            if (userResults != null)
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