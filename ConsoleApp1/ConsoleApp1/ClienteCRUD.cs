public class ClienteCRUD{
    //atributos
    private List<ClienteDTO> listaClientes; //banco de dados
    private ClienteDTO cliente;             // cliente da vez
    private Tela tela;                      // tela de apresentação
    private int linCodigo, colCodigo;
    private int posicao;
    public ClienteCRUD()
    {
        this.listaClientes = new List<ClienteDTO>();
        this.tela = new Tela();
    }

    private void entrarDados(int qual){
        if (qual == 1){
            Console.SetCursorPosition(colCodigo, linCodigo);
            this.cliente.Codigo = int.Parse(Console.ReadLine());
        }
         if (qual == 2){
            Console.SetCursorPosition(colCodigo, linCodigo+1);
            this.cliente.Nome = Console.ReadLine();
            Console.SetCursorPosition(colCodigo, linCodigo+2);
            this.cliente.Email = Console.ReadLine();
            Console.SetCursorPosition(colCodigo, linCodigo+3);
            this.cliente.Telefone = Console.ReadLine();
        }

    }




    public void executarCRUD()
    {
        //1-montar a tela do CRUD
        this.montarTelaCliente(30,5);
        //preparar um registro em branco de um cliente
        this.cliente = new ClienteDTO();
        //2-Perguntar ao usuario a chave do cliente
        this.entrarDados(1);
        //3-procurar pela chave no "Banco de dados"(listaClientes)
        bool achou = this.buscarCodigo();

        // 4-Se nao achou a chave no banco de dados

        //5-se achou a chave no bando de dados
        if(!achou){
            //4.2 - Perguntar se deseja cadastrar
            this.tela.centralizar("Cliente não encontrado. Deseja cadastrar? (S/N) ",24,0,80);
            //se o usuario informar que deseja cadastrar
            string resp = Console.ReadLine();
            //4.3.1 - perguntar os dados restantes ao usuario
            if(resp.ToLower()=="s"){
                this.entrarDados(2);
            //  4.3.2 - perguntar se o usuario confirma o cadastro.
            
            this.tela.centralizar("Confirma o cadastro (S/N)",24,0,80);
            resp = Console.ReadLine();
            //        4.3.3 - se o usuario confirmar
            if(resp.ToLower() == "s"){
            //        4.3.3.1 - realizar a inclusao do novo cliente  
            this.listaClientes.Add(this.cliente);
            }            
            
            }
        }else{
            //cofigo 5.1 em diante
        }
        /*
            Uma logica possivel para o CRUD
            -------------------------------
            
            //2-Perguntar ao usuario a chave do cliente
            //3-procurar pela chave no "Banco de dados"(listaClientes)
            4-Se nao achou a chave no banco de dados
                4.1 - informar que nao achou
                4.2 - Perguntar se deseja cadastrar
                4.3 - se o usuario informar que deseja cadastrar
                    4.3.1 - perguntar os dados restantes ao usuario
                    4.3.2 - perguntar se o usuario confirma o cadastro.
                    4.3.3 - se o usuario confirmar
                    4.3.3.1 - realizar a inclusao do novo cliente
            5-se achou a chave no bando de dados
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
    }

    private bool buscarCodigo(){
        bool encontrei = false;
        for (int i=0; i <= this.listaClientes.Count; i++){
            if (this.listaClientes[i].Codigo == this.cliente.Codigo){
                encontrei = true;
                this.posicao = i;
                break;
            }
        }
        return encontrei;
    }

/*
        private void montarTelaCliente(int coluna, int linha)
        {
            int coluna2 = coluna+30;
    
            this.tela.desenharMoldura(coluna,linha,coluna2,linha+6);
            linha++;
            this.tela.centralizar("Cadastro de Cliente",linha,coluna,coluna2);
            coluna++;
            linha++;
            Console.SetCursorPosition(coluna,linha);
            Console.Write("Codigo       :");
            linha++;
            Console.SetCursorPosition(coluna,linha);
            Console.Write("Nome         :");
            linha++;
            Console.SetCursorPosition(coluna,linha);
            Console.Write("Email        :");
            linha++;
            Console.SetCursorPosition(coluna,linha);
            Console.Write("Telefone     :");
        }
    */
    private void montarTelaCliente(int coluna, int linha){
        int coluna2 = coluna+30;
        List<string> cadCliente = new List<string>();
        cadCliente.Add("Código  :");
        cadCliente.Add("Nome  :");
        cadCliente.Add("Email  :");
        cadCliente.Add("Telefone  :");


        this.tela.desenharMoldura(coluna,linha,coluna2,linha+6);
        linha++;
        this.tela.centralizar("Cadastro de Cliente",linha,coluna,coluna2);
        coluna++;
        linha++;


        this.colCodigo = coluna + cadCliente[0].Length;
        this.linCodigo = linha;
        for(int i=0;i<cadCliente.Count; i++){
            Console.SetCursorPosition(coluna,linha);
            Console.Write(cadCliente[i]);
            linha++;
        }
    }
    }