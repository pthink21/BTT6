using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BTT6.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Họ tên")]
        public string? FullName { get; set; }

        [Display(Name = "Địa chỉ")]
        public string? Address { get; set; }
    }
}
