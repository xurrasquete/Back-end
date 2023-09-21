Console.WriteLine("Digite o valor de x:");
//Precisamos convertaer os dadso que recebemos de ReadLine
//int.Parse() para converter para inteiro
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de y:");
int y = int.Parse(Console.ReadLine());

// Exemplos de operadores aritméticos 
int soma = x + y;
int subtracao = x - y;
int multiplicacao = x * y;
int divisao = x / y;
int resto = x % y;
int restoDiv2 = x % 2; //#######

Console.WriteLine("Soma:" + soma);
Console.WriteLine("Subtração:" + subtracao);
Console.WriteLine("Multiplaicação:" + multiplicacao);
Console.WriteLine("Divisão:" + divisao);
Console.WriteLine("Resto:" + resto);

if (restoDiv2 == 0) 
{
    Console.WriteLine($"{x} é par");
} else {
    Console.WriteLine($"{x} é ímpar");
}

//Operador ternário
//condição ? se verdade : senão 
string ePar = (restoDiv2 == 0) ? "par" : "ímpar";

int diaSemana = 6 

//aprendendo switch case 
switch (diaSemana) {
    case 1 :
    Console.WriteLine("Hoje é domingo!");
    break;
    case 2 :
    Console.WriteLine("Hoje é segunda!");
    break;
    case 3 :
    Console.WriteLine("Hoje é terça!");
    break;
    case 4 : 
    Console.WriteLine("Hoje é quarta!");
    break;
    case 5 :
    Console.WriteLine("Hoje é quinta!");
    break;
    case 6 :
    Console.WriteLine("Hoje é sexta!");
    break;
    case 7 :
    Console.WriteLine("Hoje é sábado!");
    break;
    default :
    Console.WriteLine("Dia inválido!");
}
