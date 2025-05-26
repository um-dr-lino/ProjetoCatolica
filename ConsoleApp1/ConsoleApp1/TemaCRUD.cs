using System.Security.AccessControl;

public class TemaCRUD
{

	private List<TemaDTO> listaTemas;
	private TemaDTO tema;
	private Tela tela;
	private int linCodigo, colCodigo, posicao;

	public TemaCRUD()
	{
		this.listaTemas = new List<TemaDTO>();
		this.tela = new Tela();
	}

	public void executarCRUDTema()
	{
		this.montarTelaCliente(20, 5);
		Console.ReadKey();
	}

	private void montarTelaCliente(int coluna, int linha)
	{
		int coluna2 = coluna + 30;
		List<string> cadTema = new List<string>();
		cadTema.Add("Codigo		:");
		cadTema.Add("Nome		:");
		cadTema.Add("Valor		:");
		cadTema.Add("Cor		:");
		cadTema.Add("Tema		:");

		this.tela.desenharMoldura(coluna, linha, coluna2, linha + 7);
		linha++;
		this.tela.centralizar("Cadastro de Tema", linha, coluna, coluna2);
		coluna++;
		linha++;

		this.colCodigo = coluna + cadTema[0].Length;
		this.linCodigo = linha;

		for (int i = 0; i < cadTema.Count; i++)
		{
			Console.SetCursorPosition(coluna, linha);
			Console.Write(cadTema[i]);
			linha++;
		}
	}

	private void entrarDados(int qual){
		if (qual == 1){
			Console.SetCursorPosition(colCodigo, linCodigo);
			string codigo = Console.ReadLine();
			if (codigo.Length > 0) this.tema.Codigo = int.Parse(codigo);
		}
		if (qual == 2){
			this.tela.limparArea(colCodigo, linCodigo+1, colCodigo+18, linCodigo+3);
			Console.SetCursorPosition(colCodigo, linCodigo + 1);
			this.tema.NomeTema = Console.ReadLine();
			
			Console.SetCursorPosition(colCodigo, linCodigo + 2);
			this.tema.ValorTema = float.Parse(Console.ReadLine());
			
			Console.SetCursorPosition(colCodigo, linCodigo + 3);
			this.tema.CorToalha = Console.ReadLine();
			
			Console.SetCursorPosition(colCodigo, linCodigo + 4);
			this.tema.Disponbilidade = bool.Parse(Console.ReadLine());
		}
	}

}