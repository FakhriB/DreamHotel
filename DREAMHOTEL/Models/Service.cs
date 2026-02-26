using System.ComponentModel.DataAnnotations;

namespace DREAMHOTEL.Models
{
    public class Service : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(300)]
        public string Description { get; set; }

        [MaxLength(50)]
        public string Icon { get; set; } // icon
        public bool IsMain { get; set; } = true;
    }
}
