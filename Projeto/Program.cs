<<<<<<< HEAD
﻿using Projeto_em_grupo;

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

    
    


=======
﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
>>>>>>> 1c2248653bdec7db21d910ab8e848a9dc30b4185
