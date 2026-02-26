using DREAMHOTEL.Data;
using DREAMHOTEL.Models;
using DREAMHOTEL.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DREAMHOTEL.Services
{
    public class SliderService : ISliderService
     
    {
        private readonly AppDbContext _context;
        public SliderService(AppDbContext context)
        {
            _context = context;
        }
 
        public async Task<IEnumerable<Slider>> GetAllAsync()
        {
            var sliders = await _context.Sliders.ToListAsync(); 
            return sliders;
        }

        public async Task<Slider> GetByIdAsync(int id)
        {
            var slider = await _context.Sliders.FindAsync(id);
            return slider;
        }

    }
}
