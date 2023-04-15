using Microsoft.AspNetCore.Mvc;
using RegistrationServiceAPI.DTOs;
using RegistrationServiceAPI.Models;

namespace RegistrationServiceAPI.Interface
{
    public interface IRegistration
    {
        Task<ActionResult<User>> Registration(UserDTO userDTO);
    }
}
