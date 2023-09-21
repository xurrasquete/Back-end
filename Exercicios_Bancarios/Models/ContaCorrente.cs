namespace Models
{
    public class ContaBancaria
    {
        //Atributos da nossa classe Pessoa
        private string titular { get; set; }
        private decimal saldo { get; set; }

        //Criando nosso método construtor
        public ContaBancaria(string titularContaBancaria, decimal saldoContaBancaria)
        {
            this.titular = titularContaBancaria;
            this.saldo = saldoContaBancaria;
        }

        //Métodos da classe Pesssoa
        public void ConsultarSaldo()
        {
            Console.WriteLine($"{titular}, sua conta Bancária tem um total de {saldo}.");
        }

        public void DepositarConta(decimal nr)
        {
            saldo = saldo + nr;
            Console.WriteLine($" {titular} O valor depositado em sua conta foi de {nr}");
        }

        public void SacarConta(decimal nr)
        {

            if (saldo < nr){
                Console.WriteLine($"Não foi possível pois esta em saldo negativo");
            } else {
                saldo = saldo - nr;
                Console.WriteLine($"{titular} O valor que você sacou foi de {nr}");
            }
            
        }


    }
}