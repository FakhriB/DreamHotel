using System.ComponentModel.DataAnnotations;

namespace DREAMHOTEL.Models
{
    public class Room : BaseEntity
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required, MaxLength(500)]
        public string Description { get; set; }
        [Required, Range(10,2)]
        public decimal Price { get; set; }
        [Required]
        public int Capacity { get; set; }
        public string ImageUrl { get; set; }
        public bool IsAvailable { get; set; } = true;
        public int RoomTypeId { get; set; }
        public RoomType RoomType { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
}
