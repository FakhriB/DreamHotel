using System.ComponentModel.DataAnnotations;

namespace DREAMHOTEL.Models
{
    public class Blog : BaseEntity
    {
        [Required,MaxLength(200)]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public bool IsMain { get; set; } = true;
    }
}
