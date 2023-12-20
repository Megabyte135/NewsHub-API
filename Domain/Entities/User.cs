using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class User : BaseEntity
    {
        [Required]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Full name")]
        public string FullName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(255, ErrorMessage = "The password must be at least 5 characters in length", MinimumLength = 5)]
        public string Password { get; set; }
    }
}
