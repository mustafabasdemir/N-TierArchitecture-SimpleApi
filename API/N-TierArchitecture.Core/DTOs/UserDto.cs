﻿using N_TierArchitecture.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_TierArchitecture.Core.DTOs
{
    public class UserDto:BaseDto
    {
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public int GroupId { get; set; }
        public Department Department { get; set; }
        public Group Group { get; set; }
    }
}
