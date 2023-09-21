public class Program 
{
    public static void Main()
    {
        //o Try serve para tratar um erro e não parra e execução do programa
        //Se ocerrer qualquer erro dentro do bloco try, osistema interrompe
        //a execução do bloco e vai para o catch20
        try {
        Console.WriteLine("Digite um número inteiro");
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine($"Você digitou o nº {numero}");
        }
        //Tratando execeção de erro especíica de formato 
        catch (FormatException)
        {
            Console.WriteLine($"Digite um número inteiro");
        }
        //cactch é o problema do erro, normalmente colocamos as mensagens de acordo com
        //o tipo do erro, para melhorar compreensão de usuário 
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro genérico: {erro.Message}");
        }
        finally {
            Console.WriteLine($"No bloco finally o programa entra independentemente de exceção");
        }

    }
}
