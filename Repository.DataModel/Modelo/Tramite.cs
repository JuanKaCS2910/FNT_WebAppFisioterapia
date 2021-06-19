using System;
using System.Collections.Generic;

#nullable disable

namespace DataModel.Modelo
{
    public partial class Tramite
    {
        public Tramite()
        {
            SubTramites = new HashSet<SubTramite>();
        }

        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Usuariocreacion { get; set; }
        public DateTime Fechacreacion { get; set; }
        public string Usuariomodificacion { get; set; }
        public DateTime? Fechamodificacion { get; set; }

        public virtual ICollection<SubTramite> SubTramites { get; set; }
    }
}
