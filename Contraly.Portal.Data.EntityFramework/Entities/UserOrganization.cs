﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Contraly.Portal.Data.EntityFramework.Entities
{
    public class UserOrganization
    {
        public long UserId { get; set; }

        public long OrganizationId { get; set; }

        //Navigation

        public User User { get; set; }

        public Organization Organization { get; set; }
    }
}
