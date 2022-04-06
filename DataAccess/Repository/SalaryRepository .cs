using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using BusinessLayer.Models;

namespace DataAccess.Repository
{
    public class SalaryRepository : ISalaryRepository
    {
        private SalaryDAO salaryDao;

        public SalaryRepository()
        {
            salaryDao = new SalaryDAO();
        }

        public List<Salary> GetAllSalaries()
            => salaryDao.GetSalaries();

        public List<SalariesAndEmployeeDTO> GetSalariesWithMember(DateTime fromDate, DateTime toDate, string departId)
            => salaryDao.GetSalariesWithMember(fromDate,toDate,departId);

        public List<Salary> GetSalariesOfEmployee(string employeeId)
            => salaryDao.GetSalariesOfEmployee(employeeId);

        public Salary GetSalaryById(int salaryId)
            => salaryDao.GetSalaryById(salaryId);

        public Salary GetSalaryByEmployeeIdAndDate(string employeeId, DateTime date)
            => salaryDao.GetSalaryByEmployeeIdAndDate(employeeId, date);

        public void UpdateSalary(Salary updateSalary)
            => salaryDao.UpdateSalary(updateSalary);

        public void DeleteSalary(Salary deleteSalary)
            => salaryDao.DeleteSalary(deleteSalary);

        public void NewSalary(Salary newSalary)
            => salaryDao.NewSalary(newSalary);
    }
}
