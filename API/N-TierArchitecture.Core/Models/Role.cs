﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_TierArchitecture.Core.Models
{
    public class Role:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<GroupInRole> GroupInRoles { get; set; }
    }
}
