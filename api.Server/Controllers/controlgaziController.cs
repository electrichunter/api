using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using api.Server.Servisler; // IAuthService ve AuthService sınıflarını ekleyin
using api.Server.Models;

namespace api.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControlgaziController : ControllerBase
    {
        private readonly IAuthService _authService;


        public ControlgaziController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            try
            {
                var result = await _authService.LoginAsync(model.Email, model.Password);
                if (result.Success)
                {
                    return Ok(new { success = true });
                }
                else
                {
                    return Unauthorized(new { success = false, message = "Email veya parola hatalı" });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, error = "Sunucu hatası" });
            }

        }






        public class LoginModel
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }



    }
}
