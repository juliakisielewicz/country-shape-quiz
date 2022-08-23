﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuizApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace QuizApp.Data
{
    public class QuizAppContext : IdentityDbContext
    {
        public QuizAppContext (DbContextOptions<QuizAppContext> options)
            : base(options)
        {
        }

        public DbSet<QuizApp.Models.Country> Country { get; set; } = default!;
        public DbSet<QuizApp.Models.Result> Result { get; set; } = default!;

    }
}
