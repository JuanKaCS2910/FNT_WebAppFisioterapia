using System;
using System.Collections.Generic;

#nullable disable

namespace DataModel.Modelo
{
    public partial class Distrito
    {
        public Distrito()
        {
            Personas = new HashSet<Persona>();
        }

        public int DistritoId { get; set; }
        public int DepartamentoId { get; set; }
        public string Nombre { get; set; }

        public virtual Departamento Departamento { get; set; }
        public virtual ICollection<Persona> Personas { get; set; }
    }
}
