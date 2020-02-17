using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contraly.Portal.Data.EntityFramework.Mappings
{
    public class OrganizationMap : IEntityTypeConfiguration<Entities.Organization>
    {
        public void Configure(EntityTypeBuilder<Entities.Organization> builder)
        {
            builder.Property(o => o.Name)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.HasIndex(o => o.Guid)
                .IsUnique();

            //Table relationships
            builder.HasMany(o => o.Projects)
                .WithOne(p => p.Organization);
        }
    }
}
