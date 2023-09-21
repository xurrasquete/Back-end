//Classe pai que será herdada - SuperClasse

abstract class Animal 
{ 
    public string cor { get; set; }
    
    public virtual void EmitirSom()
    {
      Console.WriteLine($"Animal da {cor}, fazendo algum som");
    }
}

//Classe filha que herdará da classe animal 

class Cachorro : Animal
{   
    //Sobrescrevendo o método EmitirSom
    public override void EmitirSom()
    {
        Console.WriteLine($"Cachorro da cor {cor}, está latindo! AU AU AU");
    }
}

class Gato : Animal
{
    //Sobrescrevendo o método EmitirSom
    public override void EmitirSom()
    {
        Console.WriteLine($"Gato da cor {cor} está miando! Miua Miau");
    }

    public void Ronronar()
    {
        Console.WriteLine("o gato está ronronando!");
    }
}

class Progam 
{
    public static void Main()
    {
        /*
        Animal animalGenerico =new Animal();
        animalGenerico.EmitirSom();
        animalGenerico.cor = "preto";
        */
        
        
        Cachorro meuCachorro = new Cachorro();
        meuCachorro.cor ="caramelo";
        meuCachorro.EmitirSom();
        //meuCachorro.Ronronar(); //Não posso chamar este método pois não existe nessa classe 
        Gato meuGato = new Gato();
        meuGato.cor= "cinza";
        meuGato.EmitirSom();
    }
}