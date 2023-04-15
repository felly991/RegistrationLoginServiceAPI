using RegistrationServiceAPI.Models;

namespace RegistrationServiceAPI.DTOs
{
    public class UserDTO
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public User? user { get; set; } = null;
    }
}
