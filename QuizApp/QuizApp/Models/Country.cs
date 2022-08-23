using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace QuizApp.Models
{
    public class Country
    {
        public int id { get; set; }
        [Display(Name = "Country")]
        public string country_name { get; set; } = string.Empty;
        [Display(Name = "Shape")]
        public string image_name { get; set; } = string.Empty;

    }
}
