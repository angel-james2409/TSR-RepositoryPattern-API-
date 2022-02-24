using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Property.Models;
namespace Property.Data
{
    public class PropetyContext : DbContext
    {

        public PropetyContext(DbContextOptions<PropetyContext> options) : base(options)
        { }
        public DbSet<Properties> Properties { get; set; }

        public DbSet<User> Users { get; set; }

    }
}
