﻿using Microsoft.EntityFrameworkCore;

namespace Trail2.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<User> Users { get; set; } // Represents the Users table
    }
}