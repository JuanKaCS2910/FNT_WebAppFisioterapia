using Aplication.BusinessLogic.Interfaz;
using DataModel.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplication.BusinessLogic.Logic
{
    public class DepartamentoBusinessLogic : IDepartamentoBusinessLogic
    {
        private readonly FisioterapiaContext _context;
        public DepartamentoBusinessLogic(FisioterapiaContext context)
        {
            this._context = context;
        }

        public string CargaDepartamento()
        {
            var _resultado = _context.Departamento.Select(p => p.Nombre).FirstOrDefault();

            return _resultado;
        }
    }
}
