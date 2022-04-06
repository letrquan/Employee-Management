using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class EmployeeDAO
    {
        private EManagerPRNContext _databaseContext;

        public List<Employee> GetEmployees()
        {
            using (_databaseContext = new EManagerPRNContext())
            {
                return _databaseContext.Employees.ToList();
            }
        }

        public List<Employee> GetManager(string roleId)
        {
            using (_databaseContext = new EManagerPRNContext())
            {
                return _databaseContext.Employees
                    .Where(employee => employee.RoleId == roleId).ToList();
            }
        }

        public List<Employee> GetEmployeeOfDepartment(string departmentId)
        {
            using (_databaseContext = new EManagerPRNContext())
            {
                return _databaseContext.Employees
                    .Where(employee => employee.DepartmentId == departmentId).ToList();
            }
        }

        public Employee GetEmployeeById(string employeeId)
        {
            using (_databaseContext = new EManagerPRNContext())
            {
                return _databaseContext.Employees.Include(e => e.Salaries)
                    .FirstOrDefault(employee => employee.EmployeeId == employeeId);
            }
        }

        public void AddEmployee(Employee newEmployee)
        {
            using (_databaseContext = new EManagerPRNContext())
            {
                var check = _databaseContext.Employees.Find(newEmployee.EmployeeId);
                if (check != null)
                {
                    throw new Exception("Employee Id Existed!");
                }
                else
                {
                    _databaseContext.Add(newEmployee);
                    _databaseContext.SaveChanges();
                }
            }
        }

        public void DeleteEmployee(Employee deleteEmployee)
        {
            using (_databaseContext = new EManagerPRNContext())
            {
                _databaseContext.Remove<Employee>(deleteEmployee);
                _databaseContext.SaveChanges();
            }
        }

        public void UpdateEmployee(Employee updateEmployee)
        {
            using (_databaseContext = new EManagerPRNContext())
            {
                _databaseContext.Update<Employee>(updateEmployee);

                //Commit to Database
                _databaseContext.SaveChanges();
            }
        }

        public Employee CheckLogin(string email, string password)
        {
            using (_databaseContext = new EManagerPRNContext())
            {
                return _databaseContext.Employees.FirstOrDefault(member =>
                    member.Email == email && member.Password == password);
            }
        }

        public List<Employee> GetEmployeesByDepartmentID(string DepartmentId)
        {
            List<Employee> FList = new List<Employee>();
            for (int i = 1; i <= _databaseContext.Employees.ToList().Count; i++)
            {
                if (_databaseContext.Employees.ToList()[i - 1].DepartmentId == DepartmentId) { FList.Add(_databaseContext.Employees.ToList()[i - 1]); }
            }
            return FList;
        }

    }
}
