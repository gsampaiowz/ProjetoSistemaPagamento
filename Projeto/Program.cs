using Projeto;

Pagamento pagamento = new Pagamento();
Debito debito = new Debito();
Credito credito = new Credito();
Boleto boleto = new Boleto();

Console.WriteLine($"\nBem vindo ao nosso site de compras!");

string opcao = string.Empty;
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

    if (opcao != "4")
    {
        Console.WriteLine($"\nInsira o valor da sua compra:");
        pagamento.Valor = float.Parse(Console.ReadLine()!);
        debito.Valor = pagamento.Valor;
        credito.Valor = pagamento.Valor;
        boleto.Valor = pagamento.Valor;
        switch (opcao)
        {
            case "1":
                boleto.Registrar();
                break;
            case "2":
                Console.WriteLine($"{credito.SalvarCartao()}");
                credito.Pagar();
                break;
            case "3":
                Console.WriteLine($"{debito.SalvarCartao()}");
                debito.Pagar();
                break;
            case "4":
                Console.WriteLine($"{pagamento.Cancelar()}");
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
    }
    else
    {
        Console.WriteLine($"{pagamento.Cancelar()}");
    }
} while (opcao != "0");