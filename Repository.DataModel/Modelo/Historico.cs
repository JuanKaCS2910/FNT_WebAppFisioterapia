using System;
using System.Collections.Generic;

#nullable disable

namespace DataModel.Modelo
{
    public partial class Historico
    {
        public Historico()
        {
            AgenteElectrofisicos = new HashSet<AgenteElectrofisico>();
            AgenteTermicos = new HashSet<AgenteTermico>();
            Antecedentes = new HashSet<Antecedente>();
            FrecuenciaNavigation = new HashSet<Frecuencium>();
            ManiobrasTerapeuticas = new HashSet<ManiobrasTerapeutica>();
        }

        public int HistoricoId { get; set; }
        public int PersonaId { get; set; }
        public string Diagnostico { get; set; }
        public string Observaciones { get; set; }
        public string Otros { get; set; }
        public string Paquetes { get; set; }
        public decimal? Costo { get; set; }
        public string Frecuencia { get; set; }
        public DateTime? Fechacita { get; set; }
        public int? Horacita { get; set; }
        public string Usuariocreacion { get; set; }
        public DateTime Fechacreacion { get; set; }
        public string Usuariomodificacion { get; set; }
        public DateTime? Fechamodificacion { get; set; }

        public virtual Persona Persona { get; set; }
        public virtual ICollection<AgenteElectrofisico> AgenteElectrofisicos { get; set; }
        public virtual ICollection<AgenteTermico> AgenteTermicos { get; set; }
        public virtual ICollection<Antecedente> Antecedentes { get; set; }
        public virtual ICollection<Frecuencium> FrecuenciaNavigation { get; set; }
        public virtual ICollection<ManiobrasTerapeutica> ManiobrasTerapeuticas { get; set; }
    }
}
