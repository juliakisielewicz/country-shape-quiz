using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using QuizApp.Data;
using QuizApp.Models;

namespace QuizApp.Pages
{
    public class QuizModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public QuizModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }





    }
}