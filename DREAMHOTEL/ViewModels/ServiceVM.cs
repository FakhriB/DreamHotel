using System.ComponentModel.DataAnnotations;

namespace DREAMHOTEL.ViewModels
{
    public class ServiceVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; } // icon
        public bool IsMain { get; set; } = true;
    }
}
