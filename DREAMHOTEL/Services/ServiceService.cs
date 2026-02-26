using DREAMHOTEL.Data;
using DREAMHOTEL.Models;
using DREAMHOTEL.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DREAMHOTEL.Services
{
    public class ServiceService : IServiceService
    {
        private readonly AppDbContext _context;
        public ServiceService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Service>> GetAllAsync()
        {
            var services = await _context.Services.ToListAsync();
            return services;
        }

        public async Task<Service
            > GetByIdAsync(int id)
        {
            var services = await _context.Services.FindAsync(id);
            return services;
        }
    }
}
