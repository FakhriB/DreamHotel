using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DREAMHOTEL.Models
{
    public class AppUser : IdentityUser
    {
        public string Fullname { get; set; }
    }
}
