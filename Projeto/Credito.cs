namespace Projeto
{
    public class Credito : Cartao //herança abstrata
    {
        // atributos
        public float Limite { get; private set; }
        // métodos implementados
        public override void Pagar()
        {
            Console.WriteLine($"\nPor favor querido, digite o limite de seu cartão:");
            Limite = float.Parse(Console.ReadLine()!);
            //validando se o valor excede o limite
            if (Limite >= Valor)
            {
                //definindo quantidade de parcelas e aplicando descontos 
                float parcelas;
                do
                {
                    Console.WriteLine($"\nAgora digite o número exato de parcelas (de 1 a 12):");
                    parcelas = int.Parse(Console.ReadLine()!);
                } while (parcelas < 1 || parcelas > 12);
                float juros = 0;

                if (parcelas >= 1 && parcelas <= 6)
                {
                    juros = Valor / (float)100 * 5;
                }
                else if (parcelas >= 7 && parcelas <= 12)
                {
                    juros = Valor / (float)100 * 8;
                }

                float valorFinal = Valor + juros;
                float valorParcela = valorFinal / parcelas;
                //detalhes do pagamento
                Console.Clear();
                Console.Beep(1000, 500);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(@$"
Certo! O Valor total sera de: {valorFinal:C2} e sua compra será parcelada em {parcelas} vezes!
O preço de cada parcela será de: {valorParcela:C2}
O saldo restante na sua conta é de: {(Limite - valorParcela):C2}
Data: {Data:D}
Obrigado por comprar conosco! <3");
                Console.ResetColor();
                Console.WriteLine($"\n \nPressione qualquer tecla para retornar ao MENU");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Seu limite não é suficiente :(");
                Console.WriteLine($"{Cancelar()}");
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
            ------------------------------------
            Cartão salvo!

            Bandeira: {Bandeira}
            Número do cartão: {NumeroCartao}
            Nome do Titular: {Titular}
            CVV: {Cvv}
            --------------------------------------";

        }
    }
}