using Sesi.Model;

class Program
{
    public static void Main()
    {
       //Criando uma variável aluno1 e instaciando de classe Aluno
       //Criando nosso objeto
       var aluno1 = new Aluno();
       aluno1.nome = "Michelle";
       aluno1.idade = 16;
       aluno1.turma = "2º EM";

       //Chamando o método da classe Aluno
       aluno1.Apresentar();

       Aluno aluno2 = new Aluno();
       aluno2.nome = "Enzo";
       aluno2.idade = 3;
       aluno2.turma = "corujinha";

       aluno2.Apresentar();
       aluno2.AdicionarFaltas(10);
       aluno2.Apresentar();
       aluno2.ResumoFaltas();
       aluno2.Apresentar();

       //chamar método ResumoFaltas
       //aluno2.ResumoFaltas();
    }
}
