using DataModel.Modelo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Context
{
    public class FisioterapiaContext : DbContext
    {
        public FisioterapiaContext(DbContextOptions<FisioterapiaContext> options): base(options)
        {

        }

        public DbSet<Departamentos> Departamento { get; set; }
    }
}
