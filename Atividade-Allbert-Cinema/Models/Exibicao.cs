using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Atividade_Allbert_Cinema.Models
{
    public class Exibicao
    {
        public int Id { get; set; }
        [Required]
        public virtual Filmes Filme { get; set; }
        [Required]
        public virtual Salas Sala { get; set; }
    }
}