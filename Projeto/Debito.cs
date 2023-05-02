namespace Projeto
{
    public class Debito : Cartao
    {

        // atributos
        private float Saldo;
        public override void Pagar()
        {
             Console.WriteLine($"Por favor querido, digite o saldo atual de seu cartão:");
             Saldo = float.Parse(Console.ReadLine()!);

             if (Saldo < Valor)
             {
                Console.WriteLine($"Pagamento cancelado. Saldo insuficiente. :( ");
                
             }
             else
             {
                Console.WriteLine($"Parabens! Sua compra no total de R${Valor} foi concluida.");
                
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