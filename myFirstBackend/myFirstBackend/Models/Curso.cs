using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;

namespace myFirstBackend.Models
{
    public class Curso : baseEntity
    {

        [MaxLength(50)]
        [Required]
        public string name { get; set; } = string.Empty;

        [MaxLength(280)]
        public string descriptionShort { get; set; } = string.Empty;

        public string descriptionLong { get; set; } = string.Empty;

        public string objetivePublic { get; set; } = string.Empty; 

        public string requirement { get; set; } = string.Empty;

        public nivel level { get; set; }


        public enum nivel
        {
            basico,
            intermedio,
            avanzado
        }


    }

    /*
     Nombre (máximo

    Descripción Corta (máximo 280 caracteres)

    Descripción larga

    Público Objetivo

    Objetivos

    Requisitos

    Nivel (solo puede ser Básico, Intermedio o Avanzado para ello usa un enumerado)

     */
}
