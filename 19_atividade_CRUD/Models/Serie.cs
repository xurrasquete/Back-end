using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace App.Models
{
    [Table("Series")]
    public class Serie
    {
        [Key]
        public int SerieId { get; set; }
        public string Nome { get; set; }
        public string Sinopse { get; set; }
        public string Imagem { get; set; }
        public bool Ativo { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}