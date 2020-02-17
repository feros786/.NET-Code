using System;
using System.Collections.Generic;
using System.Text;

namespace Contraly.Portal.Data.EntityFramework.Entities
{
    public class Project : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public long CreatedBy { get; set; }

        public long LastUpdatedBy { get; set; }

        public long OrganizationId { get; set; }

        //Navigation

        public Organization Organization { get; set; }
    }
}
