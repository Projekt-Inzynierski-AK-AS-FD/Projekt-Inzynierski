using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Abituria.datamodels;
namespace Abituria.viewmodel
{
    public class SimpleDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
