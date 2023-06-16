using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechHelpDesk.Data;
using TechHelpDesk.Models;
using TechHelpDesk.Services.Interfaces;

namespace TechHelpDesk.Services
{
    public class HDCompanyInfoService : IHDCompanyInfoService
    {
        private readonly ApplicationDbContext _context;
        
        public HDCompanyInfoService(ApplicationDbContext context) 
        {
            _context = context;
        }


        public async Task<List<HDUser>> GetAllMembersAsync(int companyId)
        {
            List<HDUser> result = new();

            result = await _context.Users.Where(u => u.CompanyId == companyId).ToListAsync();

            return result;
        }

        public async Task<List<Project>> GetAllProjectsAsync(int companyId)
        {
            List<Project> result = new();

            result = await _context.Projects.Where(p => p.CompanyId == companyId)
                                            .Include(p => p.Members)
                                            .Include(p => p.Tickets)
                                                .ThenInclude(t => t.Comments)
                                            .Include(p => p.Tickets)
                                                .ThenInclude(t => t.TicketStatus)
                                            .Include(p => p.Tickets)
                                                .ThenInclude(t => t.TicketPriority)
                                            .Include(p => p.Tickets)
                                                .ThenInclude(t => t.TicketType)
                                            .Include(p => p.ProjectPriority)
                                            .ToListAsync();

            return result;
        }

        public async Task<List<Ticket>> GetAllTicketAsync(int ticketId)
        {
            throw new NotImplementedException();
        }

        public async Task<Company> GetCompanyInfoByIdAsync(int? companyId)
        {
            throw new NotImplementedException();
        }
    }
}
