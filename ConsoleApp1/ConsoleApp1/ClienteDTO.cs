public class ClienteDTO{
    // atributos
    private int? codigo;
    private string nome;
    private string email;
    private string telefone;

    public int? Codigo { get => codigo; set => codigo = value; }
    public string Nome { get => nome; set => nome = value; }
    public string Email { get => email; set => email = value; }
    public string Telefone { get => telefone; set => telefone = value; }

    public ClienteDTO(int codigo, string nome, string email, string telefone)
    {
        Codigo = codigo;
        Nome = nome;
        Email = email;
        Telefone = telefone;
    }
    public ClienteDTO()
    {
        Codigo=0;
        Nome="";
        Email="";
        Telefone="";

    }
}