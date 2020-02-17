using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contraly.Portal.Data.EntityFramework.Mappings
{
    public class UploadMap : IEntityTypeConfiguration<Entities.Upload>
    {
        public void Configure(EntityTypeBuilder<Entities.Upload> builder)
        {
            builder.Property(u => u.Name)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(u => u.Description)
                .HasColumnType("varchar(250)")
                .HasMaxLength(250);

            builder.Property(u => u.Path)
                .HasColumnType("varchar(256)")
                .HasMaxLength(256)
                .IsRequired();

            builder.Property(u => u.Folder)
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
