using System;
using System.Collections.Generic;

#nullable disable

namespace DataModel.Modelo
{
    public partial class Antecedente
    {
        public int AntecedentesId { get; set; }
        public int HistoricoId { get; set; }
        public int SubTramiteId { get; set; }
        public bool? Condicion { get; set; }
        public string Usuariocreacion { get; set; }
        public DateTime Fechacreacion { get; set; }
        public string Usuariomodificacion { get; set; }
        public DateTime? Fechamodificacion { get; set; }

        public virtual Historico Historico { get; set; }
        public virtual SubTramite SubTramite { get; set; }
    }
}
