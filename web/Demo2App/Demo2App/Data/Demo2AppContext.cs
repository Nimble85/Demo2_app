using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Demo2App.Models
{
    public class Demo2AppContext : DbContext
    {
        public Demo2AppContext (DbContextOptions<Demo2AppContext> options)
            : base(options)
        {
        }

        public DbSet<Demo2App.Models.User> User { get; set; }
    }
}
