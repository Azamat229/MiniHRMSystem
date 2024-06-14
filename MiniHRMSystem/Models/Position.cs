using System.Collections.Generic;

namespace MiniHRMSystem.Models
{
    public class Position
    {
        public int PositionId { get; set; }
        public string Title { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}