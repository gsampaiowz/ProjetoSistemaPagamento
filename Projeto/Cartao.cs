namespace Projeto
{
    public abstract class Cartao : Pagamento
    {
        //Propriedades
        public string Bandeira { get; set; } = string.Empty;
        public string NumeroCartao { get; set; } = string.Empty;
        public string Titular { get; set; } = string.Empty;
        public string Cvv { get; set; } = string.Empty;

        //Métodos
        public abstract void Pagar();
        public abstract string SalvarCartao();

    }
}