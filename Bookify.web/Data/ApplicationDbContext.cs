﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Bookify.web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<Category>().Property(e => e.CreatedOn).HasDefaultValueSql("getdate()");
            base.OnModelCreating(builder);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}