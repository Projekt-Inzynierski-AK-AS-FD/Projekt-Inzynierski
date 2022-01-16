using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abituria.datamodels;
using Microsoft.EntityFrameworkCore;
namespace Abituria.viewmodel
{
    public class SimpleDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<CompletedExercise> CompletedExercise { get; set; }
        public SimpleDbContext(DbContextOptions options) : base(options) { }
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=SimpleDb;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }*/
    }
}
