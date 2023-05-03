namespace Projeto
{
    public class Debito : Cartao
    {

        // atributos
        public float Saldo { get; private set; }
        public override void Pagar()
        {
            Console.WriteLine($"\nPor favor querido, digite o saldo atual de seu cartão:");
            Saldo = float.Parse(Console.ReadLine()!);

            if (Saldo < Valor)
            {
                Console.WriteLine($"\nSaldo insuficiente! :( ");
                Console.WriteLine($"{Cancelar()}");
            }
            else
            {
                Console.WriteLine($"\nParabéns! Sua compra no total de {Valor:C2} foi concluída. \nData: {Data:D}");
                Console.WriteLine($"\n \nPressione qualquer tecla para retornar ao MENU");
                Console.ReadKey();
            }
        }


        public override string SalvarCartao()
        {
            Console.WriteLine($"\nDigite a Bandeira do seu cartão:");
            Bandeira = Console.ReadLine()!;
            Console.WriteLine($"\nDigite o número do seu cartão:");
            NumeroCartao = Console.ReadLine()!;
            Console.WriteLine($"\nDigite o nome de Titular do seu cartão:");
            Titular = Console.ReadLine()!;
            Console.WriteLine($"\nDigite o CVV do seu cartão:");
            Cvv = Console.ReadLine()!;

            return @$"
            Cartão salvo!
            Bandeira: {Bandeira}
            Número do cartão: {NumeroCartao}
            Nome do Titular: {Titular}
            CVV: {Cvv}";
        }
    }
}