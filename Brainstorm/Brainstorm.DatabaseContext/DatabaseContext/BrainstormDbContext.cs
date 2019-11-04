using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

using Brainstorm.Model.Model;
namespace Brainstorm.DatabaseContext.DatabaseContext
{
    public class BrainstormDbContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}
