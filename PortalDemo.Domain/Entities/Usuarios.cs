namespace PortalDemo.Domain.Entities
{
    public class Usuarios
    {
        public int Id { get; set; }

        public string Usuario { get; set; }

        public string Correo { get; set; }

        public string Clave { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public bool Estado { get; set; }

        public int UsuarioCreacion { get; set; }

        public DateTime FechaCreacion { get; set; }

        public int? UsuarioModificacion { get; set; }

        public DateTime? FechaModificacion { get; set; }
    }
}