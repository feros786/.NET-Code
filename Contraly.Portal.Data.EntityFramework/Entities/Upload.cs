using System;
using System.Collections.Generic;
using System.Text;

namespace Contraly.Portal.Data.EntityFramework.Entities
{
    public class Upload : BaseEntity
    {
        public string Description { get; set; }

        public string Path { get; set; }

        public string Name { get; set; }

        public string Folder { get; set; }

        public long Size { get; set; }

        public int ProjectId { get; set; }

        //Navigation

        public Project Project { get; set; }

    }
}
