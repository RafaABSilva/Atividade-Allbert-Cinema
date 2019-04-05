using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Atividade_Allbert_Cinema.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(240)]
        public string Descricao { get; set; }
    }
}