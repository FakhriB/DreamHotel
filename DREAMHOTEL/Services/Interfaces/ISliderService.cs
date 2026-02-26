using DREAMHOTEL.Models;

namespace DREAMHOTEL.Services.Interfaces
{
    public interface ISliderService
    {
        Task<IEnumerable<Slider>> GetAllAsync();
        Task<Slider> GetByIdAsync(int id);
    
    }
}
