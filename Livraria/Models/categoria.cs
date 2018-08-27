using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Livraria.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        public Categoria()
        {
            this.Livros = new List<Livro>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe a categoria")]
        public string nome { get; set; }

        public virtual ICollection<Livro> Livros { get; set; }

    }
}