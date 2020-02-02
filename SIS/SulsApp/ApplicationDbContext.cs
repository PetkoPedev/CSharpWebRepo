using Microsoft.EntityFrameworkCore;
using SulsApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SulsApp
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-E5PBLPH\\SQLEXPRESS;Database=SulsApp;Integrated Security=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Problem> Problems { get; set; }
        public DbSet<Submission> Submissions { get; set; }
    }
}
