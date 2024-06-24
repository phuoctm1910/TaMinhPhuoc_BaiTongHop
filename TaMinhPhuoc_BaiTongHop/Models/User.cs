using System.ComponentModel.DataAnnotations;

namespace TaMinhPhuoc_BaiTongHop.Models
{
    public class User
    {
        [Required]
        public string FullName { get; set; }
        [Required]
        public string PhoneNumber {  get; set; }
        [Required]
        public string BirthDate { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
