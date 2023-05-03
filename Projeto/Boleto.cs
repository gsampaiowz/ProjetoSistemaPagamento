namespace Projeto
{
    public class Boleto : Pagamento //herança
    {
        //função para criar número aleatório
        Random Codigo = new Random();
        //propriedades
        public string CodigoBarras { get; private set; } = string.Empty;
        //métodos
        public void Registrar()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            // valor a ser pago com desconto
            Console.WriteLine(@$"
Pagamento em boleto tem 12% de desconto!
Valor final: {(Valor * 0.88F):C2}
Data de emissão do boleto: {Data:D}");
            // código de barras
            Console.WriteLine($"\nCódigo de barras: \nGerando");
            //laço de repetição para efeito sonoro
            for (int i = 0; i <= 5; i++)
            {
                Console.Beep();
                Console.Write($".");
                Thread.Sleep(150);
            }
            Console.WriteLine();
            Console.Beep(500, 1000);
            //laço de repetição para formar o código de barras
            for (int i = 0; i <= 5; i++)
            {
                //definindo quantidade de casas numerais, convertendo para string e mostrando
                Console.Write($"{this.CodigoBarras = (Codigo.Next(900000000)).ToString()} ");
            }
            Console.ResetColor();
            Console.WriteLine($"\n \nPressione qualquer tecla para retornar ao MENU");
            Console.ReadKey();
        }
    }

}