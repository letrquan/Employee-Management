using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Models;

namespace DataAccess.Repository
{
    public interface IDepartmentRepository
    {
        List<Department> GetAllDepartments();

        Department GetDepartmentById(string departmentId);

        Department GetDepartmentOfManager(string managerId);

        void UpdateDepartment(Department updateDepartment);

        void DeleteDepartment(Department deleteDepartment);

        void AddDepartment(Department newDepartment);

        Department SearchDepartmentByDepartmentId(string departmentId);
    }
}
