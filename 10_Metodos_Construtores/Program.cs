using Models;

public class Progam 
{
    public static void Main()
    {
        //Criar um objeto da classe pessoa
        /*
        //Instanciando objeto sem métod construtor
        Pessoa pessoa1 = new Pessoa();
        pessoa1.nome = "Adalberto";
        pessoa1.idade = 16;
        */

        //Instanciando objeto com o método construtor 
        Pessoa pessoa1 = new Pessoa("Alberto Roberto", 16);

        //Chamando o método Cantar da classe Pessoa
        pessoa1.Cantar();

        Pessoa pessoa2 = new Pessoa("Marcos", 17);
        pessoa2.Cantar();

        Pessoa pessoa3 = new Pessoa("Ronaldo", 18);
        pessoa3.Cantar();
    }
}
