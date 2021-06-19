using System;
using System.Collections.Generic;

#nullable disable

namespace DataModel.Modelo
{
    public partial class Tipodocumento
    {
        public Tipodocumento()
        {
            Personas = new HashSet<Persona>();
        }

        public int TipodocumentoId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Persona> Personas { get; set; }
    }
}
