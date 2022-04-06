using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessLayer.Models
{
    public partial class Salary
    {
        public int SalaryId { get; set; }
        public string EmployeeId { get; set; }
        public DateTime SalaryDate { get; set; }
        public int WorkHour { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
