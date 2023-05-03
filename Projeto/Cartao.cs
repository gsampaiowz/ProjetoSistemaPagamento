namespace Projeto
{
    public abstract class Cartao : Pagamento //herança
    {
        //Propriedades
        public string Bandeira { get; set; } = string.Empty;
        public string NumeroCartao { get; set; } = string.Empty;
        public string Titular { get; set; } = string.Empty;
        public string Cvv { get; set; } = string.Empty;
        //Métodos abstratos
        public abstract void Pagar(); //recebe o saldo/limite do cartão e prossegue com o pagamento até mostrar os detalhes finais
        public abstract string SalvarCartao(); //recebe e mostra os dados do cartão

    }
}