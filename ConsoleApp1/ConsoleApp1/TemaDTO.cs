public class TemaDTO
{
	//atributos
	private int codigo;
	private string nomeTema;
	private float valorTema;
	private string corToalha;
	private Boolean disponbilidade;

	public TemaDTO(int codigo, string nomeTema, float valorTema, string corToalha, bool disponbilidade)
	{
		this.codigo = codigo;
		this.nomeTema = nomeTema;
		this.valorTema = valorTema;
		this.corToalha = corToalha;
		this.disponbilidade = disponbilidade;
	}

	public int Codigo { get => codigo; set => codigo = value; }
	public string NomeTema { get => nomeTema; set => nomeTema = value; }
	public float ValorTema { get => valorTema; set => valorTema = value; }
	public string CorToalha { get => corToalha; set => corToalha = value; }
	public bool Disponbilidade { get => disponbilidade; set => disponbilidade = value; }
}