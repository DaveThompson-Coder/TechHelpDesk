using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechHelpDesk.Models;
using TechHelpDesk.Services.Interfaces;

namespace TechHelpDesk.Services
{
    public class HDRolesService : IHDRolesService
    {
        public Task<bool> AddUserToRoleAsync(HDUser user, string roleName)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetRoleNameByIdAsync(string roleId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> GetUserRolesAsync(HDUser user)
        {
            throw new NotImplementedException();
        }

        public Task<List<HDUser>> GetUsersInRoleAsync(string roleName, int companyId)
        {
            throw new NotImplementedException();
        }

        public Task<List<HDUser>> GetUsersNotInRoleAsync(string roleName, int companyId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsUserInRoleAsync(HDUser user, string roleName)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveUserFromRoleAsync(HDUser user, IEnumerable<string> roleName)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveUserFromRolesAsync(HDUser user, IEnumerable<string> roles)
        {
            throw new NotImplementedException();
        }
    }
}
