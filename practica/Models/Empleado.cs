using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace practica.Models
{
    public class Empleado
    {
        [Required(ErrorMessage="Escriba su nombre. ")]
        [MinLength(4, ErrorMessage ="Escriba por lo menos 4 caracteres. ")]
        [MaxLength(50, ErrorMessage ="Escriba menos de 50 caracteres. ")]
        public string? nombre {get; set;}

        [Required(ErrorMessage="Escriba su apellido. ")]
        [MinLength(4, ErrorMessage ="Escriba por lo menos 4 caracteres. ")]
        [MaxLength(50, ErrorMessage ="Escriba menos de 50 caracteres. ")]
        public string? apellido {get; set;}

        [Required(ErrorMessage="Escriba su cui. ")]
        [RegularExpression("^[0-9]{4} [0-9]{5} [0-9]{4}$", ErrorMessage ="Escribe un CUI valido. ")]
        public string? cui {get; set;}

        [Required(ErrorMessage="Escriba su correo electrónico. ")]
        [EmailAddress]
        public string? correo { get; set; }

        public bool activo {get; set;}

        [DataType(DataType.Date)]
        public DateTime fechaNacimiento {get; set;}

        [Range(18, 120, ErrorMessage ="Escriba su edad mayor a 18 años")]
        public int edad { get; set; }
        
    }
}