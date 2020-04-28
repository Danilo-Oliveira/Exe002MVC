using System;
using System.ComponentModel.DataAnnotations;

namespace Ex002.Models
{
    public class Users
    {
        
        public string Nome { get; set; }

        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data de Cadastramento")]
        public DateTime DataNascimento { get; set; }

        public float Altura { get; set; }

        public int Peso { get; set; }

        public string DiaSemana { get; set; }

        public float Imc { get; set; }
    }        
}