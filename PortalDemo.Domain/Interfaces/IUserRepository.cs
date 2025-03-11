using PortalDemo.Domain.Entities;

namespace PortalDemo.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<Usuarios> Autenticar(string usuario, string clave);
    }
}