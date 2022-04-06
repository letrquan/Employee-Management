using System;
using System.Collections.Generic;
using BusinessLayer.Models;

namespace DataAccess.Repository
{
    public class DeparmentRepository : IDepartmentRepository
    {
        private DepartmentDAO departmentDao;

        public DeparmentRepository()
        {
            departmentDao = new DepartmentDAO();
        }

        public List<Department> GetAllDepartments()
            => departmentDao.GetAllDepartments();

        public Department GetDepartmentById(string departmentId)
            => departmentDao.GetDepartmentById(departmentId);

        public Department GetDepartmentOfManager(string managerId)
            => departmentDao.GetDepartmentOfManager(managerId);

        public void UpdateDepartment(Department updateDepartment)
            => departmentDao.UpdateDeparment(updateDepartment);

        public void DeleteDepartment(Department deleteDepartment)
            => departmentDao.DeleteDepartment(deleteDepartment);

        public void AddDepartment(Department newDepartment)
            => departmentDao.CreateDepartment(newDepartment);

        public Department SearchDepartmentByDepartmentId(string departmentId)
            => departmentDao.SearchDepartmentByDepartmentId(departmentId);
    }
}
