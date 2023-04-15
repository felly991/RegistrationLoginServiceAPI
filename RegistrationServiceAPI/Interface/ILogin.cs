using Microsoft.AspNetCore.Mvc;
using RegistrationServiceAPI.DTOs;
using RegistrationServiceAPI.Models;

namespace RegistrationServiceAPI.Interface
{
    public interface ILogin
    {
        Task<ActionResult<User>> Login(UserDTO user);
    }
}
