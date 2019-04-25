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
        [Display(Name = "Nome:")]
        [MaxLength(120)]
        public string Nome { get; set; }
        [Required]
        [Display(Name = "Duração:")]
        public int Duracao { get; set; }
        [Required]
        [Display(Name = "Data de lançamento:")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }
        [Required]
        [Display(Name = "Categoria:")]
        public int CategoriaID { get; set; }
        public virtual Categorias Categoria { get; set; }
    }
}