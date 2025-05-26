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
		this.montarTelaCliente(30, 10);
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

}