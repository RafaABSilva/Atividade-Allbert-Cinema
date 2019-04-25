using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Atividade_Allbert_Cinema.Models
{
    public class Categorias
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(240)]
        [Display(Name = "Descrição:")]
        public string Descricao { get; set; }

        public Filmes Filmes {
            get {
                throw new System.NotImplementedException();
            }

            set {
            }
        }
    }
}