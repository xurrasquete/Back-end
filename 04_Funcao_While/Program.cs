class Sesi 
{
    //Método main é o ponto de entrada de um programa em C#endregio
    public static void Main()
    {
        Console.WriteLine("Estou no método main");
        Metodo();
        ImprimeDataHora();

        //Chamando o metodo somar enviando os parametros 3 e 8
        int resultadoSoma = Somar(3, 8);
        Console.WriteLine(resultadoSoma);

        ContagemRegressiva(5);
    
        JogoQueNrSouEu();
        
    }

    public static void JogoQueNrSouEu(){
        Console.WriteLine("********************");
        Console.WriteLine("Bem vindo ao jogo");
        Console.WriteLine("Sorteei um nº de 1 a 20, tente adivinha-lo");
        Console.WriteLine("*********************************************");
        Console.WriteLine(""); //Linha em branco

        Random rnd = new Random();
        int nrSorteado = rnd.Next(20);
        int nrDigitado = -1;

        do {
            Console.WriteLine("Digite um nº");
            nrDigitado = int.Parse(Console.ReadLine());
            if (nrDigitado > nrSorteado)
            Console.WriteLine("O número digitado é  MAIOR que o sorteado");
            else if (nrDigitado < nrSorteado)
            Console.WriteLine("O número digitado é MENOR  que o sorteado");
        } while (nrDigitado != nrSorteado);

        Console.WriteLine("Parabéns você acertou");
    }

    public static void ContagemRegressiva(int n)
    {
        while (n >= 0){
            Console.WriteLine(n);
            n--; //n = n - 1;
            System.Threading.Thread.Sleep(1000); // Pausa de 1s - 1000ms
        }
        Console.WriteLine("BOOOOOOOOM");
    }

    public static void Metodo()
    {
        Console.WriteLine("Estou no método / função");
       
    }

    public static void ImprimeDataHora()
    {
        Console.WriteLine(DateTime.Now.ToShortDateString());
       // Console.WriteLine(DateTime.Hour.ToString());
        Console.WriteLine(DateTime.Now.ToString());
    }

     public static int Somar(int n1, int n2)
    {
        int soma = n1 + n2;
        return soma;
    }

}
    
   

