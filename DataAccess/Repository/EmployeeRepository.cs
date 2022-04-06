using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Models;

namespace DataAccess.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private EmployeeDAO employeeDao;

        public EmployeeRepository()
        {
            employeeDao = new EmployeeDAO();
        }

        public List<Employee> GetAllEmployees()
            => employeeDao.GetEmployees();

        public List<Employee> GetAllManager(string roleId)
            => employeeDao.GetManager(roleId);

        public List<Employee> GetEmployeeOfDepartment(string departmentId)
            => employeeDao.GetEmployeeOfDepartment(departmentId);

        public Employee GetEmployeeById(string employeeId)
            => employeeDao.GetEmployeeById(employeeId);

        public void UpdateEmployee(Employee updateEmployee)
            => employeeDao.UpdateEmployee(updateEmployee);

        public void DeleteEmployee(Employee deleteEmployee)
            => employeeDao.DeleteEmployee(deleteEmployee);

        public void AddEmployee(Employee newEmployee)
            => employeeDao.AddEmployee(newEmployee);

        public Employee CheckLogin(string email, string password)
            => employeeDao.CheckLogin(email, password);

        public List<Employee> GetEmployeesByDepartmentID(string DepartmentId) => employeeDao.GetEmployeesByDepartmentID(DepartmentId);
    }
}
