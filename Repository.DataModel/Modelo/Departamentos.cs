using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataModel.Modelo
{
    public class Departamentos
    {
        [Key]
        public int DepartamentoId { get; set; }
        public string Nombre { get; set; }
    }
}
