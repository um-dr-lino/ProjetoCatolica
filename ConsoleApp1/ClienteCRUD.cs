public class ClienteCRUD{
    //atributos
    private List<ClienteDTO> listaClientes;
    private ClienteDTO cliente;

    private Tela tela;
    public ClienteCRUD(){
    this.listaClientes = new List<ClienteDTO>();
    this.cliente = new ClienteDTO();
    this.tela = new Tela();
    }

    public void executarCRUD(){
        //1 - montar a tela do crud
        this.montarTelaCliente();
        Console.ReadKey();


        /*
        Uma lógica possível para o CRUD
        ----------------------------------

        1 - montar a tela do crud 
        2 - perguntar ao usuario o código do cliente.
        3 - procurar a chave no banco de dados ("ListaClientes")
        4 - Se não achou cria 
            4.1 - Informar que não achou
            4.2 - Perguntar se deseja cadastar
            4.3 - se o usuario informar que deseja cadastrar
                4.3.1 - perguntar os dados restantes ao usuário
                4.3.2 - perguntar se o usuario confirma os valores inseridos
                4.3.3 - se o usuario confirmar 
                    4.3.3.1 - Realizar a inclusão de um novo cliente
        5 - Se achou a chave no banco de dados
            5.1 - Mostrar os dados na tela
            5.2 - Perguntar ao usuário se deseja voltar, alterar o excluir
            5.3 - se o usuario informou o deseja alterar
                5.3.1 - Pergunta os novos dados ao usuario
                5.3.2 - Pergunta se o usuario confirma a alteração
                5.3.3 - Se o usuario confirmou a alteração
                    5.3.3.1 - gravar no banco de dados a alteração feita 
            5.4 - Se o usuario infomrou que deseja excluir
                5.4.1 - pergunta se o usuario confirma a exclusão
                5.4.2 - se o usuario confirmou a exclusão
                    5.4.2.1 - Excluir o cliente do banco de dados
        */

    
    }

    public void MontarTelaCliente(){
        this.tela.desenharMoldura(20,5,60,15);
        this.tela.centralizar("Cadastro de Cliente",6,20,60,);
        Console.SetCursorPosition(21,7);
        Console.Write("Codigo   : ");
        Console.SetCursorPosition(21,8);
        Console.Write("Nome     :");
        Console.SetCursorPosition(21,9);
        Console.Write("Email    :");
        Console.SetCursorPosition(21,10);
        Console.Write("Telefone :");
        
    }

}

