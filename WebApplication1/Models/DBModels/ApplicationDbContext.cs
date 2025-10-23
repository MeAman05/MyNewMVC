﻿using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models.DBModels
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
         : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
