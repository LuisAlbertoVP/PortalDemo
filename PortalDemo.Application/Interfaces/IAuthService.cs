using PortalDemo.Domain.Entities;

namespace PortalDemo.Application.Interfaces
{
    public interface IAuthService
    {
        Task<Usuarios> Autenticar(string usuario, string clave);
    }
}