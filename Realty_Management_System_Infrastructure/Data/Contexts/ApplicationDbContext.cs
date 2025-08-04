using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Realty_Management_System_Domain.Entities;
using System.Reflection;

namespace Realty_Management_System_Infrastructure.Data.Contexts
{
    public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<int>,int>
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
