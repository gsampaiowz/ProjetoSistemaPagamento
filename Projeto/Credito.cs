namespace Projeto
{

    public class Credito : Cartao
    {

        // atributos
        private float Limite;

        // métodos

        public override void Pagar()
        {

            Console.WriteLine($"Por favor querido, digite o limite de seu cartão:");
            Limite = float.Parse(Console.ReadLine()!);

            if (Limite >= Valor)
            {
                Console.WriteLine(
             @$"Voce escolheu pagar no crédito! Escolha uma das opcoes abaixo


             -----------------------------
             [1] DE 1 A 6 PARCELAS.
             [2] DE 7 A 12 PARCELAS.
             [0] SAIR.
             -----------------------------
             ");


                string opcao = Console.ReadLine()!;

                switch (opcao)
                {
                    case "1":
                        {

                            float juros = Valor / 100 * 5;

                            Console.WriteLine($"Digite o número exato de parcelas:");
                            int parcelas = int.Parse(Console.ReadLine()!);

                            Console.WriteLine($"Certo! O Valor total sera de: R${Valor + juros} e sua compra será parcelada em {parcelas} vezes");
                            break;
                        }

                    case "2":
                        {

                            float juros = Valor / 100 * 8;


                            Console.WriteLine($"Digite o número exato de parcelas:");
                            int parcelas = int.Parse(Console.ReadLine()!);


                            Console.WriteLine($"Certo! O Valor total sera de: R${Valor + juros} e sua compra será parcelada em {parcelas} vezes");


                            break;
                        }


                    case "0":
                        {
                            break;
                        }


                    default:
                        Console.WriteLine($"Opcão inválida. Tente novamente");
                        break;
                }
            }
            else
            {
                Console.WriteLine($"Seu limite não é suficiente :( )");

            }
        }

        public override string SalvarCartao()
        {
            return @$"
            Cartão salvo!
            Bandeira: {Bandeira}
            Número do cartão: {NumeroCartao}
            Nome do Titular: {Titular}
            CVV: {Cvv}";
        }
    }
}