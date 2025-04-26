Tela tela = new Tela(80,25,ConsoleColor.Green, ConsoleColor.Yellow);
int opcao;


while(true){
    /*
    Preparar o menu com opções de CRUD do cliente
    Usuario escolhe uma opção
    executar a opção escolhida na classe cliente
    */
    tela.desenhaMoldura(0,0,79,24);
    tela.desenhaMoldura(1,1,15,10);
    tela.desenhaMoldura(17,5,70,20);
    Console.ReadKey();
}