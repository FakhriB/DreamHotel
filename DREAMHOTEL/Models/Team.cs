using System.ComponentModel.DataAnnotations;

namespace DREAMHOTEL.Models
{
    public class Team : BaseEntity
    {
        [Required, MaxLength(100)]
        public string FullName { get; set; }
        [Required, MaxLength(100)]
        public string Position { get; set; }
        public string ImageUrl { get; set; }
        [Url]
        public string FacebookUrl { get; set; }
        [Url]
        public string TwitterUrl { get; set; }
        [Url]
        public string InstagramUrl { get; set; }
        public bool IsMain { get; set; } = true;
    }
}
