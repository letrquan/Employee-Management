using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using BusinessLayer.Models;

namespace DataAccess.Repository
{
    public interface ISalaryRepository
    {
        List<Salary> GetAllSalaries();

        List<SalariesAndEmployeeDTO> GetSalariesWithMember(DateTime fromDate, DateTime toDate, string departId);

        List<Salary> GetSalariesOfEmployee(string employeeId);
        Salary GetSalaryById(int salaryId);

        Salary GetSalaryByEmployeeIdAndDate(string employeeId, DateTime date);

        void UpdateSalary(Salary updateSalary);

        void DeleteSalary(Salary deleteSalary);

        void NewSalary(Salary newSalary);
    }
}
