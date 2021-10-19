using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DEAWebApi.Domain.Models.Users
{
    public class AuthenticateRequest
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 6 and 255 characters", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
