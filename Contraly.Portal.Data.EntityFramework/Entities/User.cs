﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Contraly.Portal.Data.EntityFramework.Entities
{
    public class User : IdentityUser<int>
    {
        public string Name { get; set; }

        public string ProfileImage { get; set; }

        public DateTime CreatedDate { get; set; }

        //Navigation

        public ICollection<UserOrganization> UserOrganization { get; set; }

    }
}
