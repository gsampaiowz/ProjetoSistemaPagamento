namespace Projeto
{
    public class Boleto : Pagamento
    {
        Random Codigo = new Random();
        //propriedades
        public string CodigoBarras { get; private set; } = string.Empty;
        //métodos
        public void Registrar()
        {
            // valor a ser pago com desconto
            Console.WriteLine($"Valor: {Valor * 0.88}");
        }


        public void MostrarCodigoBarras()
        {
            Console.WriteLine($"Código de barras: {this.CodigoBarras = (Codigo.Next(900000000)).ToString()} {this.CodigoBarras = (Codigo.Next(900000000)).ToString()} {this.CodigoBarras = (Codigo.Next(900000000)).ToString()} {this.CodigoBarras = (Codigo.Next(900000000)).ToString()} {this.CodigoBarras = (Codigo.Next(900000000)).ToString()}");
        }
    }

}