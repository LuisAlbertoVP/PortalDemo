﻿namespace PortalDemo.Domain.Models
{
    public class AppSettings
    {
        public Database Database { get; set; }
    }

    public class Database
    {
        public string DataSource { get; set; }

        public string InitialCatalog { get; set; }

        public string User { get; set; }

        public string Password { get; set; }
    }
}
