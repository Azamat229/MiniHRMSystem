﻿using System.Collections.Generic;

namespace MiniHRMSystem.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Position> Positions { get; set; }
    }
}