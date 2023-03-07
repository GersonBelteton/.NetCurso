using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace practica.Models
{
    [Table("Trabajador")]
    public class Trabajador
    {
        [Key]
        public int id { get; set; }
        [Column("nombre")]
        public string? nombre { get; set; }
        [Column("apellido")]
        public string? apellido { get; set; }
        [Column("edad")]
        public int edad { get; set; }
    }
}