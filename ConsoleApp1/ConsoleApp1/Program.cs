List<string> opcoes = new List<string>();
opcoes.Add("1 - Manter Clientes");
opcoes.Add("2 - Manter Temas");
opcoes.Add("3 - Registrar Aluguel");
opcoes.Add("4 - Registrar Devolução");
opcoes.Add("0 - Sair");

Tela tela = new Tela(80, 25, ConsoleColor.Black, ConsoleColor.White);
ClienteCRUD clienteCRUD= new ClienteCRUD();
//Tela tela = new Tela(); para chamar o default que foi criado em tela
string opcao;

while (true)
{
    tela.prepararTela("Fiesta!!!");
    opcao = tela.mostrarMenu(opcoes, 1, 3);
    switch (opcao)
    {
        case "1":
            clienteCRUD.executarCRUD();
            break;
        case "2":
            Console.WriteLine("Manter Temas");
            break;
        case "3":
            Console.WriteLine("Registrar Aluguel");
            break;
        case "4":
            Console.WriteLine("Registrar Devolução");
            break;
        case "0":
            Console.WriteLine("Saindo...");
            return;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

    tela.centralizar("Pressione qualquer tecla para continuar...",24,0,80);
    Console.ReadKey();
}
