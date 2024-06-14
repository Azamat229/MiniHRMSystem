using System;

namespace MiniHRMSystem.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public byte[] Photo { get; set; }
        public int PositionId { get; set; }
        
        public bool IsDeleted { get; set; }
        public virtual Position Position { get; set; }
        
    }
}