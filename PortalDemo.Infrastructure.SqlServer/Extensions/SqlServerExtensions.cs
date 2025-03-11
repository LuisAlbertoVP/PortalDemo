using Microsoft.Data.SqlClient;
using PortalDemo.Domain.Models;

namespace PortalDemo.Infrastructure.SqlServer.Extensions
{
    public static class SqlServerExtensions
    {
        public static string ToConnectionString(this AppSettings appSettings)
        {
            var sqlConnectionStringBuilder = new SqlConnectionStringBuilder
            {
                DataSource = appSettings.Database.DataSource,
                InitialCatalog = appSettings.Database.InitialCatalog,
                UserID = appSettings.Database.User,
                Password = appSettings.Database.Password,
                TrustServerCertificate = true
            };
            return sqlConnectionStringBuilder.ToString();
        }
    }
}