using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Models;

namespace DataAccess.Repository
{
    public class RoleRepository : IRoleRepository
    {
        private RoleDAO roleDao;

        public RoleRepository()
        {
            roleDao = new RoleDAO();
        }

        public List<Role> GetRoles()
            => roleDao.GetRoles();

        public Role GetRoleIdByRoleName(string roleName)
            => roleDao.GetRoleIdByRoleName(roleName);

        public string GetRoleNameByRoleId(string roleId)
            => roleDao.getRoleNameByRoleId(roleId);
    }
}
