using Microsoft.EntityFrameworkCore;
using PortalDemo.Domain.Entities;

namespace PortalDemo.Infrastructure.SqlServer.Models
{
    public class PortalDemoContext(DbContextOptions dbContextOptions) : DbContext(dbContextOptions)
    {
        public DbSet<Usuarios> Usuarios { get; set; }
    }
}