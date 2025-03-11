using Microsoft.EntityFrameworkCore;
using PortalDemo.Domain.Entities;
using PortalDemo.Domain.Interfaces;
using PortalDemo.Infrastructure.SqlServer.Models;

namespace PortalDemo.Infrastructure.SqlServer.Repositories
{
    public class UserRepository(PortalDemoContext context) : IUserRepository
    {
        public Task<Usuarios> Autenticar(string usuario, string clave)
        {
            return context.Usuarios.FirstOrDefaultAsync(u => u.Usuario == usuario && u.Clave == clave);
        }
    }
}