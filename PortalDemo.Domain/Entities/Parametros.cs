namespace PortalDemo.Domain.Entities
{
    public class Parametros
    {
        public string Nombre { get; set; }

        public string Valor { get; set; }

        public int UsuarioCreacion { get; set; }

        public DateTime FechaCreacion { get; set; }

        public int? UsuarioModificacion { get; set; }

        public DateTime? FechaModificacion { get; set; }
    }
}