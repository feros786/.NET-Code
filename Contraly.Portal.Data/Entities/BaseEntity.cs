﻿using System;

namespace Contraly.Portal.Data.Entities
{
    public class BaseEntity
    {

        public int Id { get; set; }

        public Guid Guid { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? LastUpdatedDate { get; set; }
    }
}
