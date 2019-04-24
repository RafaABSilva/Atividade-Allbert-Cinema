using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Atividade_Allbert_Cinema.Models
{
    public class Filmes
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(120)]
        public string Nome { get; set; }
        [Required]
        public int Duracao { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }
        [Required]
        public int CategoriaID { get; set; }
        public virtual Categorias Categoria { get; set; }

    }
}