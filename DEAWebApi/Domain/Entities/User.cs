using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DEAWebApi.Domain.Entities
{
    public enum UserType
    {
        User = 1,
        Business = 2
    }
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        [JsonIgnore]
        public string PasswordHash { get; set; }
        public int CountryId { get; set; }
        [DefaultValue(1)]
        public int UserType {  get; set; }

        [ForeignKey("CountryId")]
        public Country Country { get; set; }
    }
}
