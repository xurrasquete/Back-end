class Program
{

    public static string[] poltronas = new string[51];
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Bem vidno ao SesiBus");
        Console.WriteLine("----------------------");
        Console.WriteLine("Contamos com 50 lugares disponíveis");

        Menu();
    }

    public static void Menu()
    {
        string opcao = "";
        do
        {
            Console.WriteLine("############### M E N U ##################");
            Console.WriteLine("1- Para comprar passagem");
            Console.WriteLine("2- Para poltronas disponíveis");
            Console.WriteLine("3- quantidade de poltronas disponíveis");
            Console.WriteLine("4- nome dos passageiros");
            Console.WriteLine("0- para fechar sistema");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "0":
                    Console.WriteLine("Obrigada, volte sempre !!");
                    System.Threading.Thread.Sleep(2000);
                    break;
                case "1":
                    ComprarPassagem();
                    break;
                case "2":
                    PoltronasDisponiveis();
                    break;
                case "3":
                    QuantidadePoltronas();
                    break;
                case "4":
                    NomePassageiros();
                    break;
                default:
                    Console.WriteLine("opção inválida!!!");
                    break;
            }

        } while (opcao != "0");

    }

    public static void ComprarPassagem()
    {
        Console.WriteLine("Quantas passagem deseja comprar?");
        int nrPassagem = int.Parse(Console.ReadLine());

        for (int i = 1; i <= nrPassagem; i++)
        {
            Console.WriteLine($"Digite a poltrona da {i}ª passagem:");
            int nrPoltrona = int.Parse(Console.ReadLine());
            Console.WriteLine("Informa o nome do passageiro:");
            string nome = Console.ReadLine();
            MarcarPoltrona(nrPoltrona, nome);
        }
    }


    public static void MarcarPoltrona(int nrPoltrona, string nome)
    {
        poltronas[nrPoltrona] = nome;

    }

    public static void PoltronasDisponiveis()
    {
        Console.WriteLine("Lista de poltronas disponiveis");

        for (int i = 1; i <= 50; i++)
        {
            if (poltronas[i] == null)
            {
                Console.WriteLine($"Nº {i}");
            }
        }
    }

    public static void QuantidadePoltronas()
    {
        Console.WriteLine("quantidade de poltrnoas disponíveis");

        int cont = 0;

        for (int i = 1; i <= 50; i++)
        {
            if (poltronas[i] == null)
            {
                cont++;
            }
        }
        Console.WriteLine($"{cont}");

    }

    public static void NomePassageiros()
    {
        Console.WriteLine("Nome dos passageiros");
        for (int i = 1; i <= 50; i++)
        {
            if (poltronas[i] != null)
            {
                Console.WriteLine($"nº {i} - Nome: {poltronas[i]}");
            }
        }
    }



    // foreach (string item in poltrnoas)
    // {
    //total = (item == null) ? total += 1 : total += 0;
    //   if (item == null)
    //  total = totaal + 1;
    // }
    // Console.WriteLine("Atualmente temos "+ total +" '')
}
