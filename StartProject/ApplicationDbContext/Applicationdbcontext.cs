using Microsoft.EntityFrameworkCore;
using start_project.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace start_project.ApplicationDbContext
{
    public class Applicationdbcontext:DbContext
    {
        public DbSet<Programdetails> Programdetails { get; set; }
        public DbSet<ApplicationForm> Forms { get; set; }
        public DbSet<WorkFlow> workFlows { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseCosmos(
                 "https://localhost:8081",
                 "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==",
                 "ApplicationDb"

                );
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Programdetails>().ToContainer("Program").HasPartitionKey(e => e.Id);
            modelBuilder.Entity<Programdetails>().Property(e => e.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<ApplicationForm>().ToContainer("Form").HasPartitionKey(e => e.Id);
            modelBuilder.Entity<ApplicationForm>().Property(e => e.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<WorkFlow>().ToContainer("WorkFlow").HasPartitionKey(e => e.Id);
            modelBuilder.Entity<WorkFlow>().Property(e => e.Id).ValueGeneratedOnAdd();

        }
    }
}
