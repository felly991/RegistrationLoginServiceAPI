using Microsoft.AspNetCore.Mvc;
using RegistrationServiceAPI.Data;
using RegistrationServiceAPI.DTOs;
using RegistrationServiceAPI.Interface;
using RegistrationServiceAPI.Models;

namespace RegistrationServiceAPI.Service
{
    public class RegistrationService : IRegistration
    {
        private readonly DataContext _context;

        public RegistrationService(DataContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<User>> Registration(UserDTO userDTO)
        {
            var user = userDTO.user;
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(userDTO.Password);
            user.passwordHash = passwordHash;
            user.Username = userDTO.Username;
            _context.users.Add(user);
            await _context.SaveChangesAsync();  
            return user;
        }
    }
}
