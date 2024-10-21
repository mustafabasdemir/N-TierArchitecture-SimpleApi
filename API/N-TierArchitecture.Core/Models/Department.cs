﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_TierArchitecture.Core.Models
{
    public class Department:BaseEntity
    {
        public string Name { get; set; }

        public ICollection<User> Users { get; set; }

    }
}
