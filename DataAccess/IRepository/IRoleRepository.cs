using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Models;

namespace DataAccess.Repository
{
    public interface IRoleRepository
    {
        List<Role> GetRoles();

        Role GetRoleIdByRoleName(string roleName);

        string GetRoleNameByRoleId(string roleId);
    }
}
