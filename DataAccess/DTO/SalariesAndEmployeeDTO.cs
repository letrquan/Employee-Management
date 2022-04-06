using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Models;

namespace BusinessLayer
{
    public class SalariesAndEmployeeDTO
    {
        public int SalaryId { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        public DateTime SalaryDate { get; set; }

        public int WorkHours { get; set; }
        
        public string DepartmentId { get; set; }
    }
}
