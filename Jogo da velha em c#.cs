/******************************************************************************

 Kauan Guilherme Apolinario Costa Camargo N°15 1°A - TI
 RA: 20210065

 Avaliação pessoal: 4,3 de 5,0

 Justificativa: Poderia ter colocado para a máquina jogar aleatório,
 seria mais fácil, porém quis fazer diferente! 

*******************************************************************************/
using System;
class Jogo_Velha
{
    
    static void Perfumaria()
    {
    
        Console.ForegroundColor = ConsoleColor.Yellow;   
        Console.WriteLine("§===========================================§");
        Console.ResetColor();
        
        Console.ForegroundColor = ConsoleColor.Blue; 
        Console.WriteLine("                JOGO DA VELHA                ");
        Console.ResetColor();
        
        Console.ForegroundColor = ConsoleColor.Yellow;  
        Console.WriteLine("§===========================================§");
        Console.ResetColor();
        
    }
    
    
    
  static void Main() 
  {
  
    int tst_venc=0;
    string j1="aa";
    
    Perfumaria(); 
    
    Console.ForegroundColor = ConsoleColor.Blue; 
    Console.Write("\n ●");
    Console.ResetColor();
    Console.Write(" Nickname: ");
    Console.ForegroundColor = ConsoleColor.Blue; 
    string nome = Console.ReadLine().ToLower();
    Console.ResetColor();
    
    Console.Clear();
    Perfumaria();
    Console.WriteLine("\n Ola caro(a) {0}, bem vindo(a) ao jogo da velha!!",nome);
    
    Console.Write("\n As linhas estão divididas em ");
    Console.ForegroundColor = ConsoleColor.Yellow; 
    Console.Write("1, 2 e 3");
    Console.ResetColor();
    
    Console.Write("\n As colunas, divididas em ");
    Console.ForegroundColor = ConsoleColor.Yellow; 
    Console.Write("a, b e c");
    Console.ResetColor();
    Console.WriteLine("!!");
    
    
    Console.WriteLine(" Boa sorte!!");
    Console.WriteLine("\n Enter para prosseguir...");
    Console.ReadLine();
    
    string[,] tabuleiro = new string[3,3];
    
    string simb_maq="aa";
    
    Console.Clear();
    
    Perfumaria();
    Console.WriteLine("\n Com o que desejas jogar? ");
    Console.Write(" Preencha com \"");
    Console.ForegroundColor = ConsoleColor.Yellow; 
    Console.Write("x");
    Console.ResetColor();
    Console.Write("\"");
    
    Console.Write(" ou ");
    
    Console.Write("\"");
    Console.ForegroundColor = ConsoleColor.Yellow; 
    Console.Write("o");
    Console.ResetColor();
    Console.Write("\"");
    
    Console.ForegroundColor = ConsoleColor.Yellow; 
    Console.Write("\n ● ");
    string simb_player = Console.ReadLine().ToLower();
    Console.ResetColor();
    
    
    
    if(simb_player=="x")
    {
        simb_maq="o";
    }
    
    else if(simb_player=="o")
    {
        simb_maq="x";
    }
    
    else if(simb_player!="x" && simb_player!="o")
    {
        Console.WriteLine(" Escolha entre \"x\" e \"o\"");
    }
    
    
    
    Console.Clear();
    Perfumaria();
    Console.WriteLine("\n");
    
    
    for(int i=0;i<3;i++)
    {
        for(int j=0;j<3;j++)
        {
            tabuleiro[i,j] = "|";
            
            Console.Write("\t"+tabuleiro[i,j]);
        }
        Console.WriteLine();
    }
    
    Console.WriteLine("\n");
    

    do
    {
        Console.WriteLine("\n\n");
        
        Console.ForegroundColor = ConsoleColor.Green; 
        Console.WriteLine("\t\t\t\t \"P\" = Pausar/Encerrar!!\n\n");
        Console.ResetColor();
        
        
        Console.ForegroundColor = ConsoleColor.Blue; 
        Console.Write("\n ●");
        Console.ResetColor();
        
        
        Console.Write(" Onde jogarás?: ");
        Console.ForegroundColor = ConsoleColor.Yellow; 
        j1=Console.ReadLine().ToLower();
        Console.ResetColor();
        
        
        // 1°linha
        if(j1=="1a")
        {
            tabuleiro[0,0]=simb_player;
        }
    
        else if(j1=="1b")
        {
            tabuleiro[0,1]=simb_player;
        }
    
        else if(j1=="1c")
        {
            tabuleiro[0,2]=simb_player;
        }
    
    
    
        // 2°linha
        else if(j1=="2a")
        {
            tabuleiro[1,0]=simb_player;
        }
    
        else if(j1=="2b")
        {
            tabuleiro[1,1]=simb_player;
        }
    
        else if(j1=="2c")
        {
            tabuleiro[1,2]=simb_player;
        }
    
    
    
        // 3°linha
        else if(j1=="3a")
        {
            tabuleiro[2,0]=simb_player;
        }
    
        else if(j1=="3b")
        {
            tabuleiro[2,1]=simb_player;
        }
    
        else if(j1=="3c")
        {
            tabuleiro[2,2]=simb_player;
        }
    
        
    
        
    
        //      máquina
    
        // quando não há chance de bloq. 
    
        if(tabuleiro[0,0]==simb_player && tabuleiro[0,1]=="|")
        {
            tabuleiro[0,1]=simb_maq;
        }
        
    
        else if(tabuleiro[0,1]==simb_player && tabuleiro[0,0]=="|")
        {
            tabuleiro[0,0]=simb_maq;
            
        }
        
        
        //bloqueadores
        
        //1° coluna cim. p. baix.
        else if(tabuleiro[0,0]==simb_player && tabuleiro[1,0]==simb_player && tabuleiro[2,0]=="|")
        {
            tabuleiro[2,0]=simb_maq;
        }
        
        //1° coluna baix. p. cim.
        else if(tabuleiro[2,0]==simb_player && tabuleiro[1,0]==simb_player && tabuleiro[0,0]=="|")
        {
            tabuleiro[0,0]=simb_maq;
        }
        
        //diag cim. p. baix. dir. p. esq.
        else if(tabuleiro[0,2]==simb_player && tabuleiro[1,1]==simb_player && tabuleiro[2,0]=="|")
        {
            tabuleiro[2,0]=simb_maq;
        }
        
        //diag baix. p. cim. esq. p. dir.
        else if(tabuleiro[2,0]==simb_player && tabuleiro[1,1]==simb_player && tabuleiro[0,2]=="|")
        {
            tabuleiro[0,2]=simb_maq;
        }
        
        //diag cim. p. baix. esq. p. dir.
        else if(tabuleiro[0,0]==simb_player && tabuleiro[1,1]==simb_player && tabuleiro[2,2]=="|")
        {
            tabuleiro[2,2]=simb_maq;
        }
        
        //diag baix. p. cim. dir. p. esq.
        else if(tabuleiro[2,2]==simb_player && tabuleiro[1,1]==simb_player && tabuleiro[0,0]=="|")
        {
            tabuleiro[0,0]=simb_maq;
        }
        
        //1°linha esq. p. dir.
        else if(tabuleiro[0,0]==simb_player && tabuleiro[0,1]==simb_player && tabuleiro[0,2]=="|")
        {
            tabuleiro[0,2]=simb_maq;
        }
        
        //1°linha dir. p. esq.
        else if(tabuleiro[0,2]==simb_player && tabuleiro[0,1]==simb_player &&  tabuleiro[0,0]=="|")
        {
            tabuleiro[0,0]=simb_maq;
        }
        
        
        // quando não há chance de bloq. 
    
        else if(tabuleiro[1,0]==simb_player && tabuleiro[1,1]=="|")
        {
            tabuleiro[1,1]=simb_maq;
        }
    
        else if(tabuleiro[1,1]==simb_player &&  tabuleiro[0,0]=="|")
        {
            tabuleiro[0,0]=simb_maq;
        }
        
        else if(tabuleiro[1,2]==simb_player &&  tabuleiro[0,2]=="|")
        {
            tabuleiro[0,2]=simb_maq;
        }
        
        
    
    
        
        //bloqueadores
        
        //2°linha esq. p. dir.
        else if(tabuleiro[1,0]==simb_player && tabuleiro[1,1]==simb_player && tabuleiro[1,2]=="|")
        {
            tabuleiro[1,2]=simb_maq;
        }
        
        //2°linha dir. p. esq.
        else if(tabuleiro[1,1]==simb_player && tabuleiro[1,2]==simb_player && tabuleiro[1,0]=="|")
        {
            tabuleiro[1,0]=simb_maq;
        }
        
        //2°coluna cim. p. baix.
        else if(tabuleiro[0,1]==simb_player && tabuleiro[1,1]==simb_player && tabuleiro[2,1]=="|")
        {
            tabuleiro[2,1]=simb_maq;
        }
        
        //2° coluna baix. p. cim.
        else if(tabuleiro[2,1]==simb_player && tabuleiro[1,1]==simb_player && tabuleiro[0,1]=="|")
        {
            tabuleiro[0,1]=simb_maq;
        }
        
        
        
        
        
        
        
        // quando não há chance de bloq. 
        
        else if(tabuleiro[2,0]==simb_player && tabuleiro[2,1]=="|")
        {
            tabuleiro[2,1]=simb_maq;
        }
        
        else if(tabuleiro[2,1]==simb_player && tabuleiro[2,2]=="|")
        {
            tabuleiro[2,2]=simb_maq;
        }
        
        //bloqueadores
        
        //3°linha esq. p. dir.
        else if(tabuleiro[2,0]==simb_player && tabuleiro[2,1]==simb_player && tabuleiro[2,2]=="|")
        {
            tabuleiro[2,2]=simb_maq;
        }
        
        //3°linha dir. p. esq.
        else if(tabuleiro[2,2]==simb_player && tabuleiro[2,1]==simb_player && tabuleiro[2,0]=="|")
        {
            tabuleiro[2,0]=simb_maq;
        }
        
        //3°coluna cim. p. baix.
        else if(tabuleiro[0,2]==simb_player && tabuleiro[1,2]==simb_player && tabuleiro[2,2]=="|")
        {
            tabuleiro[2,2]=simb_maq;
        }
        
        //3° coluna baix. p. cim.
        else if(tabuleiro[2,2]==simb_player && tabuleiro[1,2]==simb_player && tabuleiro[0,2]=="|")
        {
            tabuleiro[0,2]=simb_maq;
        }
        
        
        //====================================================//
        
        // máquina ganhar 
        
        //1° coluna cim. p. baix.
        else if(tabuleiro[0,0]==simb_maq && tabuleiro[1,0]==simb_maq && tabuleiro[2,0]=="|")
        {
            tabuleiro[2,0]=simb_maq;
        }
        
        //1° coluna baix. p. cim.
        else if(tabuleiro[2,0]==simb_maq && tabuleiro[1,0]==simb_maq && tabuleiro[0,0]=="|")
        {
            tabuleiro[0,0]=simb_maq;
        }
        
        //diag cim. p. baix. dir. p. esq.
        else if(tabuleiro[0,2]==simb_maq && tabuleiro[1,1]==simb_maq && tabuleiro[2,0]=="|")
        {
            tabuleiro[2,0]=simb_maq;
        }
        
        //diag baix. p. cim. esq. p. dir.
        else if(tabuleiro[2,0]==simb_maq && tabuleiro[1,1]==simb_maq && tabuleiro[0,2]=="|")
        {
            tabuleiro[0,2]=simb_maq;
        }
        
        //diag cim. p. baix. esq. p. dir.
        else if(tabuleiro[0,0]==simb_maq && tabuleiro[1,1]==simb_maq && tabuleiro[2,2]=="|")
        {
            tabuleiro[2,2]=simb_maq;
        }
        
        //diag baix. p. cim. dir. p. esq.
        else if(tabuleiro[2,2]==simb_maq && tabuleiro[1,1]==simb_maq && tabuleiro[0,0]=="|")
        {
            tabuleiro[0,0]=simb_maq;
        }
        
        //1°linha esq. p. dir.
        else if(tabuleiro[0,0]==simb_maq && tabuleiro[0,1]==simb_maq && tabuleiro[0,2]=="|")
        {
            tabuleiro[0,2]=simb_maq;
        }
        
        //1°linha dir. p. esq.
        else if(tabuleiro[0,2]==simb_maq && tabuleiro[0,1]==simb_maq &&  tabuleiro[0,0]=="|")
        {
            tabuleiro[0,0]=simb_maq;
        }
        
        //1°coluna pontas p. meio 
        else if(tabuleiro[0,0]==simb_maq && tabuleiro[2,0]==simb_maq && tabuleiro[1,0]=="|")
        {
            tabuleiro[1,0]=simb_maq;
        }
        
        //2°linha esq. p. dir.
        else if(tabuleiro[1,0]==simb_maq && tabuleiro[1,1]==simb_maq && tabuleiro[1,2]=="|")
        {
            tabuleiro[1,2]=simb_maq;
        }
        
        //2°linha dir. p. esq.
        else if(tabuleiro[1,1]==simb_maq && tabuleiro[1,2]==simb_maq && tabuleiro[1,0]=="|")
        {
            tabuleiro[1,0]=simb_maq;
        }
        
        //2°coluna cim. p. baix.
        else if(tabuleiro[0,1]==simb_maq && tabuleiro[1,1]==simb_maq && tabuleiro[2,1]=="|")
        {
            tabuleiro[2,1]=simb_maq;
        }
        
        //2° coluna baix. p. cim.
        else if(tabuleiro[2,1]==simb_maq && tabuleiro[1,1]==simb_maq && tabuleiro[0,1]=="|")
        {
            tabuleiro[0,1]=simb_maq;
        }
        
        //2°coluna pontas p. meio 
        else if(tabuleiro[0,1]==simb_maq && tabuleiro[2,1]==simb_maq && tabuleiro[1,1]=="|")
        {
            tabuleiro[1,1]=simb_maq;
        }
        
        //3°linha esq. p. dir.
        else if(tabuleiro[2,0]==simb_maq && tabuleiro[2,1]==simb_maq && tabuleiro[2,2]=="|")
        {
            tabuleiro[2,2]=simb_maq;
        }
        
        //3°linha dir. p. esq.
        else if(tabuleiro[2,2]==simb_maq && tabuleiro[2,1]==simb_maq && tabuleiro[2,0]=="|")
        {
            tabuleiro[2,0]=simb_maq;
        }
        
        //3°coluna cim. p. baix.
        else if(tabuleiro[0,2]==simb_maq && tabuleiro[1,2]==simb_maq && tabuleiro[2,2]=="|")
        {
            tabuleiro[2,2]=simb_maq;
        }
        
        //3° coluna baix. p. cim.
        else if(tabuleiro[2,2]==simb_maq && tabuleiro[1,2]==simb_maq && tabuleiro[0,2]=="|")
        {
            tabuleiro[0,2]=simb_maq;
        }
        
        //3°coluna pontas p. meio 
        else if(tabuleiro[0,2]==simb_maq && tabuleiro[2,2]==simb_maq && tabuleiro[1,2]=="|")
        {
            tabuleiro[1,2]=simb_maq;
        }
        
        

        
        
    //===========================================================================//
        
                                    //testes vencedor 
        
        //player
        
        
        //1°linha horizontal
        if(tabuleiro[0,0]==simb_player && tabuleiro[0,1]==simb_player && tabuleiro[0,2]==simb_player)
        {
            tst_venc=1;
        }
        
        
        //2°linha horizontal
        else if(tabuleiro [1,0]==simb_player && tabuleiro [1,1]==simb_player && tabuleiro [1,2]==simb_player)
        {
            tst_venc=1;
        }
        
        
        //3°linha horizontal
        else if(tabuleiro [2,0]==simb_player && tabuleiro [2,1]==simb_player && tabuleiro [2,2]==simb_player)
        {
            tst_venc=1;
        }
        
        
        //1°coluna vertical
        else if(tabuleiro [0,0]==simb_player && tabuleiro [1,0]==simb_player && tabuleiro [2,0]==simb_player)
        {
            tst_venc=1;
        }
        
        //2°coluna vertical
        else if(tabuleiro [0,1]==simb_player && tabuleiro [1,1]==simb_player && tabuleiro [2,1]==simb_player)
        {
            tst_venc=1;
        }
        
        
        //3°coluna vertical
        else if(tabuleiro [0,2]==simb_player && tabuleiro [1,2]==simb_player && tabuleiro [2,2]==simb_player)
        {
            tst_venc=1;
        }
        
        //diagonal principal
        else if(tabuleiro [0,0]==simb_player && tabuleiro [1,1]==simb_player && tabuleiro [2,2]==simb_player)
        {
            tst_venc=1;
        }
        
        //diagonal secundária
        else if(tabuleiro [0,2]==simb_player && tabuleiro [1,1]==simb_player && tabuleiro [2,0]==simb_player)
        {
            tst_venc=1;
        }
        
        
    //===========================================================================//
        
        
        //máquina
        
        
        //1°linha horizontal
        if(tabuleiro[0,0]==simb_maq && tabuleiro[0,1]==simb_maq && tabuleiro[0,2]==simb_maq)
        {
            tst_venc=2;
        }
        
        
        //2°linha horizontal
        else if(tabuleiro [1,0]==simb_maq && tabuleiro [1,1]==simb_maq && tabuleiro [1,2]==simb_maq)
        {
            tst_venc=2;
        }
        
        
        //3°linha horizontal
        else if(tabuleiro [2,0]==simb_maq && tabuleiro [2,1]==simb_maq && tabuleiro [2,2]==simb_maq)
        {
            tst_venc=2;
        }
    
    
        //1°coluna vertical
        else if(tabuleiro [0,0]==simb_maq && tabuleiro [1,0]==simb_maq && tabuleiro [2,0]==simb_maq)
        {
            tst_venc=2;
        }
    
        //2°coluna vertical
        else if(tabuleiro [0,1]==simb_maq && tabuleiro [1,1]==simb_maq && tabuleiro [2,1]==simb_maq)
        {
            tst_venc=2;
        }
    
    
        //3°coluna vertical
        else if(tabuleiro [0,2]==simb_maq && tabuleiro [1,2]==simb_maq && tabuleiro [2,2]==simb_maq)
        {
            tst_venc=2;
        }
    
        //diagonal principal
        else if(tabuleiro [0,0]==simb_maq && tabuleiro [1,1]==simb_maq && tabuleiro [2,2]==simb_maq)
        {
            tst_venc=2;
        }
    
        //diagonal secundária
        else if(tabuleiro [0,2]==simb_maq && tabuleiro [1,1]==simb_maq && tabuleiro [2,0]==simb_maq)
        {
            tst_venc=2;
        }
    
    
        
    
    //==========================================================================//
    
        //exibe tabuleiro (loop)
        
        Console.Clear();
        Perfumaria();
        Console.WriteLine("\n");
        
        for(int i=0;i<3;i++)
        {
            for(int j=0;j<3;j++)
            {
                Console.Write("\t"+tabuleiro[i,j]);
            }
        
            Console.WriteLine();
        }
        
        if(j1=="p")
        {
            Console.WriteLine("\n\n");
            Console.WriteLine(" Jogo pausado!");
        }
        
        
        else if(tst_venc==1)
        {
            Console.WriteLine("\n \"{0}\" venceu!!!",simb_player);
        }
    
        else if(tst_venc==2)
        {
            Console.WriteLine("\n \"{0}\" venceu!!!",simb_maq);
        }
    

    }while(j1!="p" && tst_venc!=1 && tst_venc!=2);
    
  }
}


