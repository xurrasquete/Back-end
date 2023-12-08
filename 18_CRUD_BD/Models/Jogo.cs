using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _18_CRUD_BD.Models
{
    //DatAnnotations de como será criado o nome na tebela do BD
    [Table("Jogos")]

    public class Jogo 
    {
        [Key] //Flando para o banco de dados que este atributo será uma chave
        public int JogoId {get; set;}
        [Required(ErrorMessage="Nome é obrigatório")]
        [Display(Name="Nome do jogo")]
        public string Nome {get; set;}
        public string Descricao {get; set;}
        public string Imagem {get; set;}
        public bool Ativo {get; set;}
    }
}