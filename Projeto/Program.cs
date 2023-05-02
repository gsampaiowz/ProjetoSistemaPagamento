using Projeto;

Pagamento pagamento = new Pagamento();
Debito debito = new Debito();
Credito credito = new Credito();
Boleto boleto = new Boleto();

Console.WriteLine($@"
    Bem vindo ao nosso site de compras!
    Insira o valor da sua compra:");
pagamento.Valor = float.Parse(Console.ReadLine()!);

string opcao;
do
{
    Console.WriteLine($@"
    Qual forma de pagamento você deseja utilizar?:
    [1] Boleto
    [2] Cartão de crédito
    [3] Cartão de débito
    [4] Cancelar operação
    [0] Sair do Sistema");
    opcao = Console.ReadLine()!;

    switch (opcao)
    {
        case "1":
            boleto.Registrar();
            break;
        case "2":
            credito.Pagar();
            break;
        case "3":
            debito.Pagar();
            break;
        case "4":
            pagamento.Cancelar();
            break;
        case "0":
            Console.WriteLine($"\n Saindo do programa...");
            Thread.Sleep(2000);
            Console.WriteLine($"\n Sistema encerrado.");
            break;
        default:
            Console.WriteLine($"\n Opção inválida!");
            break;
    }
} while (opcao != "0");

