using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataModel.Modelo
{
    public class Distritos
    {
        [Key]
        public int DistritoId { get; set; }
        public int DepartamentoId { get; set; }
        public int Nombre { get; set; }
    }
}
