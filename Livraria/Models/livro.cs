using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Livraria.Models
{
    [Table("Livros")]
    public class Livro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o título do livro")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Informe o autor do livro")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "Informe a Editora")]
        public string Editora { get; set; }

        [Required(ErrorMessage = "Informe a Edição")]
        public int Edicao { get; set; }

        [Required(ErrorMessage = "Informe o ano da Edição")]
        public int Ano { get; set; }

        [Required(ErrorMessage = "Informe o Número de páginas")]
        public int Paginas { get; set; }

        public int Estoque { get; set; }

        public int categoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
          
    }
}