using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLayer;
using BusinessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class SalaryDAO
    {
        private EManagerPRNContext _databaseContext;

        public List<Salary> GetSalaries()
        {
            using (_databaseContext = new EManagerPRNContext())
            {
                return _databaseContext.Salaries.Include(s => s.Employee).ToList();
            }
        }

        public List<Salary> GetSalariesOfEmployee(string employeeId)
        {
            using (_databaseContext = new EManagerPRNContext())
            {
                return _databaseContext.Salaries.Where(s => s.EmployeeId == employeeId).ToList();
            }
        }

        public Salary GetSalaryById(int salaryId)
        {
            using (_databaseContext = new EManagerPRNContext())
            {
                return _databaseContext.Salaries.Find(salaryId);
            }
        }

        public Salary GetSalaryByEmployeeIdAndDate(string employeeId ,DateTime date)
        {
            using (_databaseContext = new EManagerPRNContext())
            {
                return _databaseContext.Salaries
                    .FirstOrDefault(salary => salary.EmployeeId == employeeId && salary.SalaryDate == date);
            }
        }

        public void NewSalary(Salary newSalary)
        {
            using (_databaseContext = new EManagerPRNContext())
            {
                Salary check = _databaseContext.Salaries
                    .FirstOrDefault(salary => salary.EmployeeId == newSalary.EmployeeId && salary.SalaryDate == newSalary.SalaryDate);
                if (check != null)
                {
                    return;
                }
                else
                {
                    _databaseContext.Add(newSalary);
                    _databaseContext.SaveChanges();
                }
            }
        }

        public void DeleteSalary(Salary deleteSalary)
        {
            using (_databaseContext = new EManagerPRNContext())
            {
                _databaseContext.Remove<Salary>(deleteSalary);
                _databaseContext.SaveChanges();
            }
        }

        public void UpdateSalary(Salary updateSalary)
        {
            using (_databaseContext = new EManagerPRNContext())
            {
                _databaseContext.Update<Salary>(updateSalary);
                _databaseContext.SaveChanges();
            }
        }

        public List<SalariesAndEmployeeDTO> GetSalariesWithMember(DateTime fromDate, DateTime toDate, string departId)
        {
            using (_databaseContext = new EManagerPRNContext())
            {
                var data = _databaseContext.Salaries
                    .Join(
                        _databaseContext.Employees,
                        salary => salary.EmployeeId,
                        employee => employee.EmployeeId,
                        (salary, employee) => new SalariesAndEmployeeDTO()
                        {
                            SalaryId = salary.SalaryId,
                            EmployeeId = employee.EmployeeId,
                            EmployeeName = employee.Fullname,
                            SalaryDate = salary.SalaryDate,
                            WorkHours = salary.WorkHour,
                            DepartmentId = employee.DepartmentId,
                        }
                    ).Where(s => s.SalaryDate >= fromDate && s.SalaryDate <= toDate && s.DepartmentId == departId ).ToList();
                return data;
            }
        }

    }
}