
public class Progam
{
    public static void Main()
    {
    var pessoa1 = new {
    nome = "joão",
    idade = 20
    };
    var pessoa2 = new{
        nome = "maria",
        udade = 17
    };
    Console.WriteLine($"a Pessoa 1 se chma {pessoa1.nome} e a pessoa 2{pessoa2.nome}");

   Console.WriteLine("Digite o modelo do carro");
   string modeloDigitado = Console.ReadLine();
   Console.WriteLine($"Digite a marca do carro");
   string marcaDigitado = Console.ReadLine();
   Console.WriteLine("Digite o ano do carro");
   string anoDigitado = Console.ReadLine();
   
    var carro1 = new {
        modelo = modeloDigitado,
        marca = marcaDigitado,
        ano = anoDigitado
    };
    Console.WriteLine($"Meu carro da marca {carro1.marca}, modelo {carro1.modelo} e ano {carro1.ano}");
    }
}