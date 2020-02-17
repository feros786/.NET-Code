using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contraly.Portal.Data.EntityFramework.Mappings
{
    public class UserOrganizationMap : IEntityTypeConfiguration<Entities.UserOrganization>
    {
        public void Configure(EntityTypeBuilder<Entities.UserOrganization> builder)
        {
            
        }
    }
}
