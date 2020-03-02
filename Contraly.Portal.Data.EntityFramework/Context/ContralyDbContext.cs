using Contraly.Portal.Data.Entities;
using Contraly.Portal.Data.EntityFramework.Mappings;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Contraly.Portal.Data.EntityFramework.Context
{
    public class ContralyDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public ContralyDbContext(DbContextOptions<ContralyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Upload> Uploads { get; set; }
        public DbSet<UserOrganization> UserOrganizations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new OrganizationMap());
            modelBuilder.ApplyConfiguration(new ProjectMap());
            modelBuilder.ApplyConfiguration(new UploadMap());
            modelBuilder.ApplyConfiguration(new UserOrganizationMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
