using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegistrationServiceAPI.DTOs;
using RegistrationServiceAPI.Interface;
using RegistrationServiceAPI.Models;

namespace RegistrationServiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILogin _log;

        public LoginController(ILogin reg)
        {
            _log = reg;
        }
        [HttpPost]
        public async Task<ActionResult<User>> Registration(UserDTO userDTO)
        {
            var ret = _log.Login(userDTO);
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
