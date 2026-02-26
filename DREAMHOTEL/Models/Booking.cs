using System.ComponentModel.DataAnnotations;

namespace DREAMHOTEL.Models
{
    public class Booking : BaseEntity
    {
        [Required,MaxLength(100)]
        public string FullName { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        [Required,Phone]
        public string Phone { get; set; }
        [Required]
        public DateTime CheckIn { get; set; }
        [Required]
        public DateTime CheckOut { get; set; }
        [Range(1, 10)]
        public int Adults { get; set; }
        [Range(0,5)]
        public int Children { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public bool IsConfirmed { get; set; } = false;
    }
}
