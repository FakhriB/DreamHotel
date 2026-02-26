using DREAMHOTEL.Models;

namespace DREAMHOTEL.Services.Interfaces
{
    public interface IServiceService
    {
        Task<IEnumerable<Service>> GetAllAsync();
        Task<Service> GetByIdAsync(int id);
    }
}
