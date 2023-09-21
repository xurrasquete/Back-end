//Exercício Calculando a média de 3 notas de um aluno

Console.WriteLine("Qual seu nome?");
string nome = Console.ReadLine();

Console.WriteLine($"{nome}, digite aqui sua primeira nota");
int nota1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite aqui sua segunda nota");
int nota2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite aqui sua terceira nota");
int nota3 = int.Parse(Console.ReadLine());

int media = (nota1 + nota2 + nota3) / 3;
if (media < 7) {
   Console.WriteLine($"{nome}, você foi APROVADO(a)");
} else {
    Console.WriteLine($"{nome}, você foi REPROVADO(a)");
}


//Exibir uma mensagem se o aluno está aprovado considerando nota acima de 7


