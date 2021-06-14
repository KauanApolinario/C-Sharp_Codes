/******************************************************************************

Kauan Guilherme Apolinário Costa Camargo N°15 1°A-TI

*******************************************************************************/
using System;
class Trabalho12
{
    
    static double media_tot(double nota_1,double nota_2,double nota_3) 
    {
        double soma_g = (nota_1+nota_2+nota_3);
        double media_g = soma_g/3;
        return (media_g);
    }
    
  static void Main() 
  {
    Console.WriteLine("\nCalculando Médias\n");
    /*==========================================================================*/
    
    
    double[] notas_g = {0,0,0};
    
    int x=1;
    for(x=1;x<=4;x++)
    {
        
        Console.Write("Digite o nome do aluno " + x +":");
        string nomes_alunos = Console.ReadLine();
    
    int i=0;
    for(i=0;i<3;i++)
        {
            Console.Write("Digite a nota "+ (i+1) +" do aluno "+ x +":");
            notas_g[i] = Convert.ToDouble (Console.ReadLine());
        }
        
    double nota_1 = notas_g[0];
    double nota_2 = notas_g[1];
    double nota_3 = notas_g[2];
    
    double media_f = media_tot(nota_1,nota_2,nota_3);
    
    Console.WriteLine("Media final de " + nomes_alunos + " = " + media_f+"!!");
    
    if(media_f>=8)
    {
    Console.WriteLine("Parabéns pela sua nota "+nomes_alunos+"!!\n");
    Console.WriteLine("======================================\n");
    }
    
    else if(media_f>=6 & media_f<8)
    {
    Console.WriteLine(nomes_alunos+" ficou na média!! "+"\n"); 
    Console.WriteLine("======================================\n");
    }
    
    else if(media_f>=5 & media_f<6)
    {
    Console.WriteLine(nomes_alunos+" quase atingiu a média!! "+"\n");
    Console.WriteLine("======================================\n");
    }
    
    else if(media_f<5)
    {
    Console.WriteLine(nomes_alunos+" precisa estudar mais!! "+"\n");
    Console.WriteLine("======================================\n");
    }
    }
  }
}



