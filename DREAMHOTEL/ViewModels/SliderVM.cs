  using DREAMHOTEL.Models;

namespace DREAMHOTEL.ViewModels
{
    public class SliderVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? SubTitle { get; set; }
        public string? ImageUrl { get; set; }
        public IFormFile? Image { get; set; }
        public int Order { get; set; }
        public bool IsMain { get; set; }


    }
}
