using System;
using System.Collections.Generic;
using System.Text;

namespace Contraly.Portal.Data.Entities
{
    public class Project : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int CreatedBy { get; set; }

        public int? LastUpdatedBy { get; set; }

        public int OrganizationId { get; set; }

        //Navigation

        public Organization Organization { get; set; }

        public ICollection<Upload> Uploads { get; set; }
    }
}
