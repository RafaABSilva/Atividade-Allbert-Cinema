using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Atividade_Allbert_Cinema.Models
{
    public class Filmes
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(120)]
        public string Nome { get; set; }
        [Required]
        public int Duracao { get; set; }
        [Required]
        public int DataLancamento { get; set; }
        [Required]
        public virtual Categorias Categoria { get; set; }

    }
}