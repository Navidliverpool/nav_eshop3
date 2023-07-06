using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using nav_eshop3.Models;

namespace nav_eshop3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SalesCustomer> SalesCustomers { get; set; }
        public DbSet<nav_eshop3.Models.Product>? Product { get; set; }
    }
}