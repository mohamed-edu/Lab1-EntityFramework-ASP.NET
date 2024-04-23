using Lab1_EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Lab1_EntityFramework.Data
{
    public class Lab1DbContext : IdentityDbContext
    {
        public Lab1DbContext(DbContextOptions<Lab1DbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<leave> Leaves { get; set; }
        public DbSet<LeaveType> leaveTypes { get; set; }
    }
}
