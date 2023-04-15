using Microsoft.AspNetCore.Mvc;
using RegistrationServiceAPI.Data;
using RegistrationServiceAPI.DTOs;
using RegistrationServiceAPI.Interface;
using RegistrationServiceAPI.Models;

namespace RegistrationServiceAPI.Service
{
    public class LoginService : ILogin
    {

        private readonly DataContext _context;

        public LoginService(DataContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<User>> Login(UserDTO user)
        { 

            var us = await _context.users.FindAsync(user.Username);
            if (BCrypt.Net.BCrypt.Verify(user.Password, us.passwordHash))
            {
                return us;
            }
            else
            {
                return null;
            }
        }
    }
}
