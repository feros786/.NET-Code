using System;
using System.Collections.Generic;

namespace Contraly.Portal.Data.Entities
{
    public class Organization : BaseEntity
    {
        public string Name { get; set; }

        public int CreatedBy { get; set; }

        public int? LastUpdatedBy { get; set; }

        //Navigation

        public ICollection<UserOrganization> UserOrganizations { get; set; }

        public ICollection<Project> Projects { get; set; }
    }
}
