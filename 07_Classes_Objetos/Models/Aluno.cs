
//O namespace é um nome em que usaremos para fazer referência quando usarmos
namespace Sesi.Model
{
    public class Aluno
    {
        //Declaremos os atribiutos (propriedadaes) da classe Aluno
        public string nome {get; set;}
        public int idade {get; set;}
        public string turma {get; set;}

        //Declarando atributo privado

       public int nrFaltas {get; set;}
       
        //Criando um metódo 
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {nome}, eu tenho {idade} anos e estudo na turma {turma} e tenho {nrFaltas} faltas");
        }

        public void AdicionarFaltas(int nr)
        {
            Console.WriteLine($"O aluno {nome} faltou hoje e somou {nr}");
            nrFaltas = nrFaltas + nr;
        }

        public void ResumoFaltas()
        {
            Console.WriteLine($"O aluno {nome} tem um total de {nrFaltas} faltas");
        }

        //Método ResumoFaltas 
       // public void ResumoFaltas()
        //{
        //    Console.WriteLine($"O aluno {nome} tem {nrFlatas} faltas");
      //  }
    }
}