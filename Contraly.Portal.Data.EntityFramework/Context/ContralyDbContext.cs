using Contraly.Portal.Data.EntityFramework.Entities;
using Contraly.Portal.Data.EntityFramework.Mappings;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contraly.Portal.Data.EntityFramework.Context
{
    public class ContralyDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public ContralyDbContext(DbContextOptions<ContralyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Entities.Organization> Organizations { get; set; }
        public DbSet<Entities.Project> Projects { get; set; }
        public DbSet<Entities.Upload> Uploads { get; set; }
        public DbSet<Entities.UserOrganization> UserOrganizations { get; set; }

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
