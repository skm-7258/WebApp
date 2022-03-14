﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class AppDbContext :DbContext
    { 
        public AppDbContext(DbContextOptions<AppDbContext>options):base (options)
        { }
        public DbSet<Student> Student { get; set; }
    }
}
