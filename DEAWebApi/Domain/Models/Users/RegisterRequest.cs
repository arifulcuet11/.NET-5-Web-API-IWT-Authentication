using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DEAWebApi.Domain.Models.Users
{
    public class RegisterRequest
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 6 and 255 characters", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 6 and 255 characters", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        public int CountryId {  get; set; }
        [Required]
        [Range(1, 2, ErrorMessage = "User Type between 1 and 2")]
        public int UserType { get; set; }
        [Required]
        public bool IsDataStore { get; set; }
        [Required]
        public bool IsAgreeTermCondition { get; set; }
    }
}
