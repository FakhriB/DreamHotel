using System.ComponentModel.DataAnnotations;

namespace DREAMHOTEL.Models
{
    public class RoomType : BaseEntity
    {
            
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }
}
