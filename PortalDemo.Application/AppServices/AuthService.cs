using PortalDemo.Application.Interfaces;
using PortalDemo.Domain.Entities;
using PortalDemo.Domain.Interfaces;

namespace PortalDemo.Application.AppServices
{
    public class AuthService(IUserRepository userRepository) : IAuthService
    {
        public Task<Usuarios> Autenticar(string usuario, string clave)
        {
            return userRepository.Autenticar(usuario, clave);
        }
    }
}