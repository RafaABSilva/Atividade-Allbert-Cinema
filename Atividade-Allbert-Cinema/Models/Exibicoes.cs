using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Atividade_Allbert_Cinema.Models
{
    public class Exibicoes
    {
        public int Id { get; set; }

        [Required]
        public int FilmeID { get; set; }
        public virtual Filmes Filme { get; set; }

        [Required]
        public int SalaID { get; set; }
        public virtual Salas Sala { get; set; }
    }
}