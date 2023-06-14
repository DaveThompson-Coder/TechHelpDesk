using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechHelpDesk.Models;

namespace TechHelpDesk.Services.Interfaces
{
    public interface IHDRolesService
    {
        public Task<bool> IsUserInRoleAsync(HDUser user, string roleName);

        public Task<IEnumerable<string>> GetUserRolesAsync(HDUser user);        //Returns a list of strings if you have more than one role

        public Task<bool> AddUserToRoleAsync(HDUser user, string roleName);     //Add user to Roles List  

        public Task<bool> RemoveUserFromRoleAsync(HDUser user, string roleName);   //Remove user from a single Role

        public Task<bool> RemoveUserFromRolesAsync(HDUser user, IEnumerable<string> roles);     //Remove user from multiple Roles


        public Task<List<HDUser>> GetUsersInRoleAsync(string roleName, int companyId);     //Get Users in Role for a specific Company

        public Task<List<HDUser>> GetUsersNotInRoleAsync(string roleName, int companyId);   //Get Users Not in Role for a specific Company

        public Task<string> GetRoleNameByIdAsync(string roleId);    //Get Role Name based on it's Id
    }
}
