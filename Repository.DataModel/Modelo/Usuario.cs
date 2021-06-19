using System;
using System.Collections.Generic;

#nullable disable

namespace DataModel.Modelo
{
    public partial class Usuario
    {
        public int UsuarioId { get; set; }
        public int PersonaId { get; set; }
        public string CodUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Correo { get; set; }
        public string Usuariocreacion { get; set; }
        public DateTime Fechacreacion { get; set; }
        public string Usuariomodificacion { get; set; }
        public DateTime? Fechamodificacion { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
