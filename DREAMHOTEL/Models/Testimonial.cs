using System.ComponentModel.DataAnnotations;

namespace DREAMHOTEL.Models
{
    public class Testimonial : BaseEntity
    {
        [Required,MaxLength(100)]
        public string Fullname { get; set; }
        
        [MaxLength(100)]
        public string? Position { get; set; }

        [Required, MaxLength(500)]
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
        [Range(1, 5)]
        public int Rating { get; set; } // 1-5
        public bool IsActive { get; set; } = true;
    }
}
