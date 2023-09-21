using System.Collections.Generic;
using Sesi.Models;


public class Program
{
    
    public static void Main()
    {
       //Craindo uma lista de números inteiros
       List<int> listaNumero = new List<int>();

       //Adicionando elementos a lista
       listaNumero.Add(10); //posição {0}
       listaNumero.Add(20); //posição {1}
       listaNumero.Add(40); //posição {2}

       //Contando a quantidade de elementos em nossa lista
       Console.WriteLine($"Neste momento temos {listaNumero.Count} números");

       //Acessando os dados de lista peli índice
       Console.WriteLine(listaNumero[1]);

       listaNumero.Add(6);  //posição {3
       Console.WriteLine($"Neste meomemnto temos {listaNumero.Count} números");

       Console.WriteLine("--------------");

       //Criem uma nova lista de nomes e adicione alguns nome a ela
       //e exibam a qunatidade de nome que contèm nessa lista

       List<string> listaNome = new List<string>();

       listaNome.Add("Michelle"); //posição {0}
       listaNome.Add("Maria"); //posição {1}
       listaNome.Add("Enzo"); //posição {2}


       Console.WriteLine($"Neste momento temos {listaNome.Count} nomes");

       Console.WriteLine("--------------");


       foreach (string item in listaNome)
       {
        Console.WriteLine(item);
       }

       Console.WriteLine("--------------");

       //Criando uma lista já atribuindo valores
       List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9};
       numeros.Add(10);

       ////Interando sobre todos os itens da lista
       foreach (int item in numeros)
       {
        Console.WriteLine(item);
       }

       numeros.Remove(2); //Removendo o elemento buscando pelo conteúdo
       numeros.RemoveAt(4); //Remove o elemento pela posição (índice)
       numeros.RemoveRange(2, 2); //Remove o elemento da posição 2 e os próximos 2

       foreach (int item in numeros)
       {
        Console.WriteLine(item);
       }

       //Criando uma nova listacom o objetos da classe Aluno
       List<Aluno> listaAlunos = new List<Aluno>();

       //Adicionando um novo aluno a listaAluno
       Aluno novoAluno = new Aluno("Marcos", 15);
       listaAlunos.Add(novoAluno);

       listaAlunos.Add(new Aluno ("César", 17));
       listaAlunos.Add(new Aluno ("Ronaldo", 18));
       listaAlunos.Add(new Aluno ("Alice", 25));

       foreach (Aluno item in listaAlunos)
       {
        Console.WriteLine($"Nome aluno: {item.nome} idade {item.idade}");
       }

       //Criando uma nova lista, filtrando e ordenando por nome
       //LINQ utilizando Sintaxe de consulta
       var consulta = from aluno in listaAlunos 
                       where aluno.idade > 18
                       orderby aluno.nome
                       select aluno;
        Console.WriteLine("Lista de alunos maiores de 18 anos");
        foreach (var item in consulta)
        {
            Console.WriteLine($"Nome aluno: {item.nome} - {item.idade}");
        }                              

        //LINQ utilizando Sintaxe de método
        var metodo = listaAlunos 
                           .Where(aluno => aluno.idade< 18)
                           .OrderBy(aluno => aluno.nome);
        Console.WriteLine("Lista de alunos menores de 18 anos");
        foreach (var item in metodo)
        {
            Console.WriteLine($"Nome aluno: {item.nome} - {item.idade}");
        }                   


    }
}
