using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practica.Models
{
    using Microsoft.EntityFrameworkCore;
    public class EmpleadoCTX : DbContext
    {
        

        public EmpleadoCTX(DbContextOptions<EmpleadoCTX> options) : base(options){

        }

        public DbSet<Trabajador> Trabajador {get; set;}
    }
}