using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abituria.viewmodel
{
    public class SimpleDbContextFactory : IDesignTimeDbContextFactory<SimpleDbContext>
    {
        public SimpleDbContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<SimpleDbContext>();
            options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=SimpleDb;Trusted_Connection=True;");
            return new SimpleDbContext(options.Options);
        }
    }
}
