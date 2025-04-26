public class Tela{
    private int largura;
    private int altura;
    private ConsoleColor corFundo;
    private ConsoleColor corTexto;

    public Tela(int largura, int altura, ConsoleColor fundo, ConsoleColor texto) {
        this.largura    = largura;
        this.altura     = altura; 
        this.corFundo   = fundo;
        this.corTexto   = texto;
    }

    
    //metodo para preparar a tela 
    public void prepararTela(){
        Console.ForegroundColor = corTexto;
        Console.BackgroundColor = corFundo;
        Console.Clear();
        this.desenhaMoldura(0,0,this.largura,this.altura);
    }

    //--====metodo para desenhar molduras===--//
    /*O primeiro elemento sempre é a coluna e o segundo sempre é a linha*/
    public void desenhaMoldura(int colIni, int linIni, int colFin, int linFin){
        //linhas horizontais 
        for(int x=colIni; x<= colFin; x++){
            Console.SetCursorPosition(x, linIni);
            Console.Write("-");
            Console.SetCursorPosition(x, linFin);
            Console.Write("-");
        }	
        //linhas verticais
        for(int y =linIni; y<= linFin; y++){
            Console.SetCursorPosition(colIni, y);
            Console.Write("|");
            Console.SetCursorPosition(colFin, y);
            Console.Write("|");
        }	
        //cantos 
        Console.SetCursorPosition(colIni,linIni); Console.Write("+");
        Console.SetCursorPosition(colIni,linFin); Console.Write("+");
        Console.SetCursorPosition(colFin,linIni); Console.Write("+");
        Console.SetCursorPosition(colFin,linFin); Console.Write("+");
    }
    //metodo para centralizar titulos

    //metodo para mostrar um menu 
 
}