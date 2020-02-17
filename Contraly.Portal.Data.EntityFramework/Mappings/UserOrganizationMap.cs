using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Contraly.Portal.Data.EntityFramework.Mappings
{
    public class UserOrganizationMap : IEntityTypeConfiguration<Entities.UserOrganization>
    {
        public void Configure(EntityTypeBuilder<Entities.UserOrganization> builder)
        {
            builder.HasKey(uo => new
            {
                uo.OrganizationId,
                uo.UserId
            });

            builder.HasOne(uo => uo.Organization)
                .WithMany(o => o.UserOrganizations)
                .HasForeignKey(uo => uo.OrganizationId);

            builder.HasOne(uo => uo.User)
                .WithMany(u => u.UserOrganizations)
                .HasForeignKey(uo => uo.UserId);
        }
    }
}
