//somente declaramos a variável como inteira e não atribuimos valor 
int num1;

//Declarando uma variável do tipo inteira e atribuindo o valor 5 
int num2;

//Declarando uma variável do tipo string
string nomeAluno;

//variável do tipo lógico (verdadeiro ou falso)
bool resultado = true;

//variável do tipo valor com casaas decimais - para valores mais precisos 
double cordenada = 1.80;

//varia´vel do tipo decimal - mais usada para valor monetário 
decimal valor = 1.80M;

int idade = 16;
string nome = "Michelle";
Console.WriteLine($"Meu nome é {nome} e tenho {idade}");

Console.WriteLine("Em que Cidade você nasceu?");
//Recebendo uma informação do usúario e atribuindo na variável cidade
string cidade = Console.ReadLine();
Console.WriteLine($"Você nasceu em {cidade}");

int novaIdade = 16 + 5;
int anoNascimento = 2023 - 16;
Console.WriteLine($"Você nasceu em {anoNascimento} e daqui 5 anos terá {novaIdade}");