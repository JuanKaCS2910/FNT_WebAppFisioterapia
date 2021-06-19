using System;
using System.Collections.Generic;

#nullable disable

namespace DataModel.Modelo
{
    public partial class SubTramite
    {
        public SubTramite()
        {
            AgenteElectrofisicos = new HashSet<AgenteElectrofisico>();
            AgenteTermicos = new HashSet<AgenteTermico>();
            Antecedentes = new HashSet<Antecedente>();
            Frecuencia = new HashSet<Frecuencium>();
            ManiobrasTerapeuticas = new HashSet<ManiobrasTerapeutica>();
        }

        public int SubTramiteId { get; set; }
        public string Descripcion { get; set; }
        public string Codigo { get; set; }
        public string Usuariocreacion { get; set; }
        public DateTime Fechacreacion { get; set; }
        public string Usuariomodificacion { get; set; }
        public DateTime? Fechamodificacion { get; set; }

        public virtual Tramite CodigoNavigation { get; set; }
        public virtual ICollection<AgenteElectrofisico> AgenteElectrofisicos { get; set; }
        public virtual ICollection<AgenteTermico> AgenteTermicos { get; set; }
        public virtual ICollection<Antecedente> Antecedentes { get; set; }
        public virtual ICollection<Frecuencium> Frecuencia { get; set; }
        public virtual ICollection<ManiobrasTerapeutica> ManiobrasTerapeuticas { get; set; }
    }
}
