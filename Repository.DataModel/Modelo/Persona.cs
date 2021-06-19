using System;
using System.Collections.Generic;

#nullable disable

namespace DataModel.Modelo
{
    public partial class Persona
    {
        public Persona()
        {
            Historicos = new HashSet<Historico>();
            Usuarios = new HashSet<Usuario>();
        }

        public int PersonaId { get; set; }
        public int TipodocumentoId { get; set; }
        public string Nrodocumento { get; set; }
        public string Nombre { get; set; }
        public string Apellidopaterno { get; set; }
        public string Apellidomaterno { get; set; }
        public string Nrotelefono { get; set; }
        public DateTime? Fecnacimiento { get; set; }
        public int DistritoId { get; set; }
        public string Direccion { get; set; }
        public string Ocupacion { get; set; }
        public int SexoId { get; set; }
        public string Usuariocreacion { get; set; }
        public DateTime Fechacreacion { get; set; }
        public string Usuariomodificacion { get; set; }
        public DateTime? Fechamodificacion { get; set; }

        public virtual Distrito Distrito { get; set; }
        public virtual Sexo Sexo { get; set; }
        public virtual Tipodocumento Tipodocumento { get; set; }
        public virtual ICollection<Historico> Historicos { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
