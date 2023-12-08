using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace App.Models
{

    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int categoriaId { get; set; }
        public string CategoriaNome { get; set; }
        public string Sinopse { get; set; }
        public List<Serie> Series { get; set; }
    }
}