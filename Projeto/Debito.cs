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
                Console.WriteLine($"\n \nPressione qualquer tecla para retornar ao MENU.");
                Console.ReadKey();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(@$"
Parabéns! Sua compra no total de {Valor:C2} foi concluída!
O saldo restante na sua conta é de: {Saldo - Valor:C2}
Data: {Data:D}
Obrigado por comprar conosco! <3");
                Console.ResetColor();
                Console.WriteLine($"\n \nPressione qualquer tecla para retornar ao MENU");
                Console.ReadKey();
            }
        }


        public override string SalvarCartao()
        {
            Console.WriteLine($"\nPrimeiro digite os dados do seu cartão:");

            Console.WriteLine($"\nDigite a Bandeira do seu cartão:");
            Bandeira = Console.ReadLine()!;
            Console.WriteLine($"\nDigite o número do seu cartão:");
            NumeroCartao = Console.ReadLine()!;
            Console.WriteLine($"\nDigite o nome de Titular do seu cartão:");
            Titular = Console.ReadLine()!;
            Console.WriteLine($"\nDigite o CVV do seu cartão:");
            Cvv = Console.ReadLine()!;

            return @$"
            ---------------------------------
            Cartão salvo!

            Bandeira: {Bandeira}
            Número do cartão: {NumeroCartao}
            Nome do Titular: {Titular}
            CVV: {Cvv}
            ----------------------------------";
        }
    }
}