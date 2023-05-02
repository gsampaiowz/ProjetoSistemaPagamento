using Projeto_em_grupo;

Pagamento din = new Pagamento();


Console.WriteLine($@"
    Bem vindo ao nosso site de compras!
    Insira o valor da sua compra:");
    din.Valor = float.Parse(Console.ReadLine());


    Console.WriteLine($@"
    Qual forma de pagamento você deseja utilizar?:
    [1] Boleto
    [2] Cartão de crédito
    [3] Cartão de débito
    [4] Cancelar operação
    [0] Sair do Sistema");
    string opcao = Console.ReadLine();

    switch (opcao)
    {
    case "4":
    din.Cancelar();
    break;
    }

    
    


