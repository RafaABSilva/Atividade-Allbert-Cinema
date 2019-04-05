using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Atividade_Allbert_Cinema.Models
{
    public class Sala
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(120)]
        public string Nome { get; set; }
        [Required]
        public int Capacidade { get; set; }
        [Required]
        public float TamanhoDaTela { get; set; }
    }
}