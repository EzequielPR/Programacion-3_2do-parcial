using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace robos.Data.Models
{
    [Table("Robos")]
    public class Robo
    {
        [Required]
        [Key, Column(Order = 1)]
        public int Id { get; set; }

        [Required]
        [MinLength(11)][MaxLength(11)]
        public string Cedula { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public string Descripcion { get; set; }

        [Required]
        public int Valor { get; set; }

        [Required]
        public string Direccion { get; set; }

        [Required]
        public float Latitud { get; set; }

        [Required]
        public float Longitud { get; set; }
    }
}