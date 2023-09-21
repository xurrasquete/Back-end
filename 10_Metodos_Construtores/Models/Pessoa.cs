namespace Models 
{
    public class Pessoa 
    {
       //Atributos da nossa classe Pessoa
        public string nome { get; set; }
        public int idade { get; set; }

        //Criando nosso método construtor
        public Pessoa (string nomePessoa, int idadePessoa)
        {
            this.nome = nomePessoa;
            this.idade = idadePessoa;
        }
        
        //Métodos da classe Pesssoa
        public void Cantar()
        {
            Console.WriteLine($"{nome} está cantando");
        } 
    }
}