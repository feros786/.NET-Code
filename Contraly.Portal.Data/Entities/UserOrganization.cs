using System;
using System.Collections.Generic;
using System.Text;

namespace Contraly.Portal.Data.Entities
{
    public class UserOrganization
    {
        public int UserId { get; set; }

        public int OrganizationId { get; set; }

        //Navigation

        public User User { get; set; }

        public Organization Organization { get; set; }
    }
}
