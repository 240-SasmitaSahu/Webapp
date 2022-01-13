using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Webapp.Models;

namespace Webapp.Data
{
    public class WebappContext : DbContext
    {
        public WebappContext (DbContextOptions<WebappContext> options)
            : base(options)
        {
        }

        public DbSet<Webapp.Models.Employee> Employee { get; set; }
    }
}
