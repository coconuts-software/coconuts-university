using System;
namespace Seguridad.API.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Rol { get; set; }
    }
}
