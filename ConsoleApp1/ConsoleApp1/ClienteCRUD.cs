using System.Security.AccessControl;
 
public class ClienteCRUD{
    //atributos
    private List<ClienteDTO> listaClientes;//banco de dados
    private ClienteDTO cliente;             
    private Tela tela;
    private int linCodigo, colCodigo, posicao;
 
    public ClienteCRUD()
    {
        this.listaClientes = new List<ClienteDTO>();
        this.tela = new Tela();
    }
    public void executarCRUD(){
        //1-montar a tela do CRUD
        this.montarTelaCliente(10, 5);
        //prepara um registro em branco de cliente
        this.cliente = new ClienteDTO();
        // 2-Perguntar ao usuario a chave do cliente
        this.entrarDados(1);
        //3-procurar pela chave no "Banco de dados"(listaClientes)
        bool achou = this.buscarCodigo();
        // 4-Se nao achou a chave no banco de dados
        if (!achou)
        {
            //4.1 - informar que nao achou
            this.tela.centralizar("Cliente nao encontrado. deseja cadastrar (S/N): ", 24, 0, 80);
            //4.2 - Perguntar se deseja cadastrar
            string resp = Console.ReadLine();
            //4.3 - se o usuario informar que deseja cadastrar
            if (resp.ToLower() == "s")
            {
                //4.3.1 - perguntar os dados restantes ao usuario
                this.entrarDados(2);
                //4.3.2 - perguntar se o usuario confirma o cadastro.
                this.tela.centralizar("Confirma cadastro(S/N)",24,0,80);
                resp = Console.ReadLine();
                //4.3.3 - se o usuario confirmar
                if (resp.ToLower() == "s")
                {
                    //4.3.3.1 - realizar a inclusao do novo cliente
                    this.incluirRegistro();
                }
               
 
            }
        }
        //5-se achou a chave no bando de dados
        else
        {
        //  5.1 - mostrar os dados na tela
        this.mostrarDados();

        // 5.2 - perguntar ao usuario se deseja voltar,alterar ou excluir
        this.tela.centralizar("Deseja Voltar/Alterar/Excluir (V/A/E)",24,0,80);
        string resp = Console.ReadLine();

        // 5.3 - se o usuario informou que deseja alterar
        if (resp.ToLower() == "a"){
            this.tela.centralizar("Digite apenas o dado que deseja alterar",24,0,80);
            // 5.3.1 - pergunta os novos dados para o usuario
            this.entrarDados(2);
            // 5.3.2 - pergunta se o usuario confirma a alteracao
            this.tela.centralizar("Confirma alteracao(s/n)",24,0,80);
            resp = Console.ReadLine();
            // 5.3.3 - se o usuario confirmou a alteracao
            if (resp.ToLower()=="s"){
                // 5.3.3.1 - gravar a alteracao dos dados do cliente
                this.alterarRegistro();
            }
        }
        // 5.4 - se o usuario informou que deseja excluir
        if (resp.ToLower() == "e"){
        // 5.4.1 - pergunta se o usuario confirma a exclusao
        this.tela.centralizar("Confirma exclusao(s/n)",24,0,80);
        resp = Console.ReadLine();
        // 5.4.2 - se o usuario confirmou a exclusao
            if(resp.ToLower()=="s"){
            //   5.4.2.1 - excluir cliente
            this.excluirRegistro();
            }
        }

        }

        /*
            Uma logica possivel para o CRUD
            ------------------------------
       
                5.1 - mostrar os dados na tela
                5.2 - perguntar ao usuario se deseja voltar,alterar ou excluir
                5.3 - se o usuario informou que deseja alterar
                    5.3.1 - pergunta os novos dados para o usuario
                    5.3.2 - pergunta se o usuario confirma a alteracao
                    5.3.3 - se o usuario confirmou a alteracao
                        5.3.3.1 - gravar a alteracao dos dados do cliente
                5.4 - se o usuario informou que deseja excluir
                    5.4.1 - pergunta se o usuario confirma a exclusao
                    5.4.2 - se o usuario confirmou a exclusao
                        5.4.2.1 - excluir cliente
        */
        Console.ReadKey();
    }
 
    private bool buscarCodigo()
    {
        bool encontrei = false;
    //lista clientes.find resumir isso aqui pesuisar
        for (int i = 0; i < this.listaClientes.Count; i++)
        {
            if (this.listaClientes[i].Codigo == this.cliente.Codigo)
            {
                encontrei = true;
                this.posicao = i;
                break;
            }
        }
        return encontrei;
    }

    private void alterarRegistro(){
        if (this.cliente.Nome != ""){
            this.listaClientes[this.posicao].Nome = this.cliente.Nome;
        }
        if (this.cliente.Email != ""){
            this.listaClientes[this.posicao].Email = this.cliente.Email;
        }
        if (this.cliente.Telefone != ""){
            this.listaClientes[this.posicao].Telefone = this.cliente.Telefone; 
            }
    }

    private void excluirRegistro(){
            this.listaClientes.RemoveAt(this.posicao);
        
    }

    private void incluirRegistro(){
        this.listaClientes.Add(this.cliente);
    }

    private void mostrarDados(){

        Console.SetCursorPosition(colCodigo, linCodigo + 1);
        Console.Write(this.listaClientes[this.posicao].Nome);

        Console.SetCursorPosition(colCodigo, linCodigo + 2);
        Console.Write(this.listaClientes[this.posicao].Email);

        Console.SetCursorPosition(colCodigo, linCodigo + 3);
        Console.Write(this.listaClientes[this.posicao].Telefone);
    }

    private void entrarDados(int qual)
    {
        //entrada de codigo(chave primaria / identificador unico)
        if (qual == 1)
        {
            Console.SetCursorPosition(colCodigo, linCodigo);
            this.cliente.Codigo = int.Parse(Console.ReadLine());
        }
        //entrada de dados do registro
        if (qual == 2)
        {
            this.tela.limparArea(colCodigo, linCodigo+1, colCodigo+18, linCodigo+3);
            Console.SetCursorPosition(colCodigo, linCodigo + 1);
            this.cliente.Nome = Console.ReadLine();
 
            Console.SetCursorPosition(colCodigo, linCodigo + 2);
            this.cliente.Email = Console.ReadLine();
 
            Console.SetCursorPosition(colCodigo, linCodigo + 3);
            this.cliente.Telefone = Console.ReadLine();
 
        }
    }
        private void montarTelaCliente(int coluna, int linha)
    {
        int coluna2 = coluna + 30;
        List<string> cadCliente = new List<string>();
        cadCliente.Add("Código    :");
        cadCliente.Add("Nome      :");
        cadCliente.Add("Email     :");
        cadCliente.Add("Telefone  :");
 
 
        this.tela.desenharMoldura(coluna, linha, coluna2, linha + 6);
        linha++;
        this.tela.centralizar("Cadastro de Cliente", linha, coluna, coluna2);
        coluna++;
        linha++;
 
        this.colCodigo = coluna + cadCliente[0].Length;
        this.linCodigo = linha;
 
        for (int i = 0; i < cadCliente.Count; i++)
        {
            Console.SetCursorPosition(coluna, linha);
            Console.Write(cadCliente[i]);
            linha++;
        }
    }
 
}