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
            Console.WriteLine(@$"
Pagamento em boleto tem 12% de desconto!
Valor final: {(Valor * 0.88F):C2}
Data de emissão do boleto: {Data:D}");
            // código de barras
            Console.WriteLine($"\nCódigo de barras: ");
            for (int i = 0; i <= 5; i++)
            {
                Console.Write($"{this.CodigoBarras = (Codigo.Next(900000000)).ToString()} ");

            }
            Console.WriteLine($"\n \nPressione qualquer tecla para retornar ao MENU");
            Console.ReadKey();
        }
    }

}