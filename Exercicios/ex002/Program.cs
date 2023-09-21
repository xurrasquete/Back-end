Console.WriteLine("Qual sua placa?");
string placa = Console.ReadLine();
const ultimo = string.substring(string.length - 1);
 if (ultimo == "1" || ultimo == "2")
 {
    Console.WriteLine($"o útilmo caracter da sua placa é {ultimo}, você não pode andar na segunda");
 } else {
    Console.WriteLine($"o útilmo caracter da sua placa é {ultimo}, você pode andar na segunda");
 }

