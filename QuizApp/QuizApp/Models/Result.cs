using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace QuizApp.Models
{
    public class Result
    {
        public int id { get; set; }
        public int correct_answer { get; set; }
        public int selected_answer { get; set; }
        public string user_id { get; set; }
    }
}
