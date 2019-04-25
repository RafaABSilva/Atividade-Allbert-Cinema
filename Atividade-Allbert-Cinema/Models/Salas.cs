using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Atividade_Allbert_Cinema.Models
{
    public class Salas
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(120)]
        [Display(Name = "Nome:")]
        public string Nome { get; set; }
        [Required]
        [Display(Name = "Capacidade:")]
        public int Capacidade { get; set; }
        [Required]
        [Display(Name = "Tamanho da Tela:")]
        public string TamanhoDaTela { get; set; }
    }
}