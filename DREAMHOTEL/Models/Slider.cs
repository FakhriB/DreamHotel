using System.ComponentModel.DataAnnotations;

namespace DREAMHOTEL.Models
{
    public class Slider : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(200)]
        public string SubTitle { get; set; }
        public string ImageUrl { get; set; }
        public int Order { get; set; }
        public bool IsMain { get; set; } = true;

    }
}
