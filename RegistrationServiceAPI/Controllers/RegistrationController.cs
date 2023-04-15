using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegistrationServiceAPI.DTOs;
using RegistrationServiceAPI.Interface;
using RegistrationServiceAPI.Models;
using System.ComponentModel.Design;

namespace RegistrationServiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly IRegistration _reg;

        public RegistrationController(IRegistration reg)
        {
            _reg = reg;
        }
        [HttpPost]
        public async Task<ActionResult<User>> Registration(UserDTO userDTO)
        {
            var ret = _reg.Registration(userDTO);
            if (ret == null)
            {
                return BadRequest();
            }
            else
            {
                return await ret;
            }

        }
    }
}
