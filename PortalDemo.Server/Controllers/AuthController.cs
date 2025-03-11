using Microsoft.AspNetCore.Mvc;
using PortalDemo.Application.Interfaces;
using PortalDemo.Domain.Entities;

namespace PortalDemo.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IAuthService authService) : ControllerBase
    {
        [HttpGet]
        public Task<Usuarios> Autenticar([FromQuery] string usuario, [FromQuery] string clave)
        {
            return authService.Autenticar(usuario, clave);
        }
    }
}