using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Swag.Data
{
    public class SwagContext : IdentityDbContext<IdentityUser>
    {
        public SwagContext(DbContextOptions<SwagContext> options)
            : base(options)
        {
        }

        public DbSet<Swag.Models.Employee> Employee { get; set; } = default!;
        public DbSet<Swag.Models.LeaveRequest> LeaveRequest { get; set; } = default!;
        public DbSet<Swag.Models.Roaster> Roaster { get; set; } = default!;
    }
}
