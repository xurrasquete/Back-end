class Progam 
{
    public static void Main ()
    {
        ListaChurrasco();
    }

    public static void ListaChurrasco()
    {
        string[] produtos = new string[6];
        for (int i = 0; i < produtos.Length; i++)
        {
            Console.WriteLine("Digite os itens:");
            string produto = Console.ReadLine();
            produtos[i] = produto;
        }
        Array.Sort(produtos);
        for (int i = 0; i < produtos.Length; i++)
        {
            Console.WriteLine(produtos[i]);
        }
    }

    public static void SonhosDeConsumo(){
        string[] listaSonhos = new string[3];
        int[] valorSonhos = new int[3];
        int soma = 0;

        for (int i = 0; i < listaSonhos.Length; i++)
        {
            Console.WriteLine("Informe o sonho:");
            string sonho = Console.ReadLine();
            listaSonhos[i] = sonho;

            Console.WriteLine("Informe o valor:");
            int valor= Console.ReadLine();
            valorSonhos[i] = valor;
        }  

        foreach (int item in listaSonhos)
        soma += item;
        Console.WriteLine($"Seus sonhos custarão R$ {soma}");
    
    }
}
