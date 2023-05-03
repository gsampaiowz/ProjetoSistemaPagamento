//acessando a pasta do programa
using Projeto;

//instanciando todas as classes
Pagamento pagamento = new Pagamento();
Debito debito = new Debito();
Credito credito = new Credito();
Boleto boleto = new Boleto();

//inicio
Console.WriteLine($"\nBem vindo ao nosso site de compras!");

//MENU principal
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

    //caso escolha um método de pagamento
    if (opcao != "4")
    {
        Console.WriteLine($"\nInsira o valor da sua compra:");
        pagamento.Valor = float.Parse(Console.ReadLine()!);
        //atribuindo o valor para todas as classes filhas
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
                Thread.Sleep(1500);
                Console.WriteLine($"\n Sistema encerrado.");
                break;
            default:
                Console.WriteLine($"\n Opção inválida!");
                break;
        }
    }
    //caso cancele a operação
    else
    {
        Console.WriteLine($"{pagamento.Cancelar()}");
        Console.WriteLine($"\n \nPressione qualquer tecla para retornar ao MENU");
        Console.ReadKey();
    }
} while (opcao != "0");