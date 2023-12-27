using System.ComponentModel.DataAnnotations;

namespace WebTracNghiem.Models
{
    public class LoginRequest
    {
        public string Mssv { get; set; }
        [Required]
        [MinLength(6)]
        [MaxLength(100)]
        public string Password { get; set; }
    }

}

