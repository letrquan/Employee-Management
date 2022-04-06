using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Models;

namespace DataAccess.Repository
{
    public interface IEmployeeRepository
    {

        List<Employee> GetAllEmployees();

        List<Employee> GetAllManager(string roleId);

        List<Employee> GetEmployeeOfDepartment(string departmentId);
        Employee GetEmployeeById(string employeeId);

        void UpdateEmployee(Employee updateEmployee);

        void DeleteEmployee(Employee deleteEmployee);

        void AddEmployee(Employee newEmployee);

        Employee CheckLogin(string email, string password);

        List<Employee> GetEmployeesByDepartmentID(string DepartmentId);
    }
}
