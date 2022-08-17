using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuizApp.Models;

namespace QuizApp.Data
{
    public class QuizAppContext : DbContext
    {
        public QuizAppContext (DbContextOptions<QuizAppContext> options)
            : base(options)
        {
        }

        public DbSet<QuizApp.Models.Country> Country { get; set; } = default!;
    }
}
