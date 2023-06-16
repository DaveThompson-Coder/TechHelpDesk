using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechHelpDesk.Models;

namespace TechHelpDesk.Services.Interfaces
{
    public interface IHDCompanyInfoService
    {
        public Task<Company> GetCompanyInfoByIdAsync(int? companyId);

        public Task<List<HDUser>> GetAllMembersAsync(int companyId);

        public Task<List<Project>> GetAllProjectsAsync(int companyId);

        public Task<List<Ticket>> GetAllTicketAsync(int ticketId);

    }
}
