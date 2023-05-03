namespace Projeto
{
    public class Credito : Cartao
    {
        // atributos
        public float Limite { get; private set; }

        // métodos
        public override void Pagar()
        {

            Console.WriteLine($"\nPor favor querido, digite o limite de seu cartão:");
            Limite = float.Parse(Console.ReadLine()!);

            if (Limite >= Valor)
            {
                string opcao = string.Empty;
                do
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(@$"
Voce escolheu pagar no crédito! Escolha uma das opcoes abaixo:
-----------------------------
[1] DE 1 A 6 PARCELAS.
[2] DE 7 A 12 PARCELAS.
[0] CANCELAR.
-----------------------------");
                    opcao = Console.ReadLine()!;
                    Console.ResetColor();
                    float juros = 0;
                    float valorFinal = 0;
                    int parcelas = 0;
                    float valorParcela = 0;
                    switch (opcao)
                    {
                        case "1":
                            {
                                juros = Valor / (float)100 * 5;
                                valorFinal = Valor + juros;
                                do
                                {
                                    Console.WriteLine($"\nDigite o número exato de parcelas (de 1 a 6):");
                                    parcelas = int.Parse(Console.ReadLine()!);
                                } while (parcelas < 1 || parcelas > 6);
                                valorParcela = valorFinal / parcelas;
                                break;
                            }

                        case "2":
                            {
                                juros = Valor / (float)100 * 8;
                                valorFinal = Valor + juros;
                                do
                                {
                                    Console.WriteLine($"\nDigite o número exato de parcelas (de 7 a 12):");
                                    parcelas = int.Parse(Console.ReadLine()!);
                                } while (parcelas < 7 || parcelas > 12);
                                valorParcela = valorFinal / parcelas;
                                break;
                            }

                        case "0":
                            {
                                Console.WriteLine($"{Cancelar()}");
                                Console.WriteLine($"\n \nPressione qualquer tecla para retornar ao MENU");
                                Console.ReadKey();
                                break;
                            }

                        default:
                            Console.WriteLine($"\nOpcão inválida. Tente novamente");
                            break;
                    }
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
                } while (opcao != "0");
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