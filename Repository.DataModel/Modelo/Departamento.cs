using System;
using System.Collections.Generic;

#nullable disable

namespace DataModel.Modelo
{
    public partial class Departamento
    {
        public Departamento()
        {
            Distritos = new HashSet<Distrito>();
        }

        public int DepartamentoId { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Distrito> Distritos { get; set; }
    }
}
