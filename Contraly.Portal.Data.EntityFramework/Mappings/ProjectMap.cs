using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Contraly.Portal.Data.EntityFramework.Mappings
{
    public class ProjectMap : IEntityTypeConfiguration<Entities.Project>
    {
        public void Configure(EntityTypeBuilder<Entities.Project> builder)
        {
            builder.Property(p => p.Name)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(p => p.Description)
                .HasColumnType("varchar(250)")
                .HasMaxLength(250);

            builder.HasMany(p => p.Uploads)
                .WithOne(u => u.Project);

            builder.HasIndex(p => p.Guid)
                .IsUnique();
        }
    }
}
