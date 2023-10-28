using System.ComponentModel.DataAnnotations;

namespace OOP_6.Models.DTO
{
    public class UserDto
    {
        [Required(ErrorMessage = "First Name is required.")]
        [StringLength(50, ErrorMessage = "First Name cannot exceed 50 characters.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [StringLength(50, ErrorMessage = "Last Name cannot exceed 50 characters.")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string? Email { get; set; }

        [StringLength(100, ErrorMessage = "Address cannot exceed 100 characters.")]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Birth Date is required.")]
        [DataType(DataType.Date, ErrorMessage = "Invalid Date Format.")]
        [Range(typeof(DateTime), "1/1/1900", "1/1/2015")]
        public DateTime BirthDate { get; set; }
    }
}
