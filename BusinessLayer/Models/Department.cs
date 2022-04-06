using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessLayer.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public string DepartmentId { get; set; }
        public string ManagerId { get; set; }
        public string DepartmentName { get; set; }
        public short BaseSalary { get; set; }

        public virtual Employee Manager { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
