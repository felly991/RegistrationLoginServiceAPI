using RegistrationServiceAPI.DTOs;
using System.ComponentModel.DataAnnotations;

namespace RegistrationServiceAPI.Models
{
    public class User
    {
        [Key]
        public string Username { get; set; } = string.Empty;
        public string passwordHash { get; set; } = string.Empty;
        
    }
}
