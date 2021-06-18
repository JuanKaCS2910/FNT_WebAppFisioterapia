using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplication.BusinessLogic.Interfaz;
using DataModel.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace FNT_WebAppFisioterapia.Controllers
{
    public class DashboardsController : Controller
    {
        private readonly IDepartamentoBusinessLogic _oIDepartamentoBusinessLogic;
        public DashboardsController(IDepartamentoBusinessLogic oIDepartamentoBusinessLogic)
        {
            this._oIDepartamentoBusinessLogic = oIDepartamentoBusinessLogic;
        }

        public IActionResult Dashboard_1()
        {
            var resultado = _oIDepartamentoBusinessLogic.CargaDepartamento();

            return View();
        }

        public IActionResult Dashboard_2()
        {
            return View();
        }

        public IActionResult Dashboard_3()
        {
            return View();
        }

        public IActionResult Dashboard_4()
        {
            return View();
        }

        public IActionResult Dashboard_4_1()
        {
            return View();
        }

        public IActionResult Dashboard_5()
        {
            return View();
        }
    }
}