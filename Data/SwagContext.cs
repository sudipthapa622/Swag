using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Swag.Models;

namespace Swag.Data
{
    public class SwagContext : DbContext
    {
        public SwagContext (DbContextOptions<SwagContext> options)
            : base(options)
        {
        }

        public DbSet<Swag.Models.Employee> Employee { get; set; } = default!;
        public DbSet<Swag.Models.LeaveRequest> LeaveRequest { get; set; } = default!;
        public DbSet<Swag.Models.Roaster> Roaster { get; set; } = default!;
        
    }
}
