using Models;

public class Progam
{
    public static void Main()
    {

        //Instanciando objeto com o método construtor 

        Console.WriteLine("Digite aqui o nome do titular da conta!");
        string titularDigitado = Console.ReadLine();

        ContaBancaria conta1 = new ContaBancaria(titularDigitado, 0);


        string opcao = "";
        do
        {
            Console.WriteLine("############### M E N U ##################");
            Console.WriteLine("1- Para consultar sua conta bancária");
            Console.WriteLine("2- Para depositar na sua conta bancária");
            Console.WriteLine("3- Para sacar da sua conta bancária");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "0":
                    Console.WriteLine("Obrigada, volte sempre !!");
                    System.Threading.Thread.Sleep(2000);
                    break;
                case "1":
                    conta1.ConsultarSaldo();
                    break;
                case "2":
                    Console.WriteLine("Qual o valor que pretende depositar na sua conta?");
                    decimal nr = decimal.Parse(Console.ReadLine());
                    conta1.DepositarConta(nr);
                    break;
                case "3":
                    Console.WriteLine("Qual o valor que pretende sacar da sua conta?");
                    decimal nr2 = decimal.Parse(Console.ReadLine());
                    conta1.SacarConta(nr2);
                    break;
                default:
                    Console.WriteLine("opção inválida!!!");
                    break;


            } 




        } while (opcao != "0") ;

        conta1.DepositarConta(0);

    }
}

