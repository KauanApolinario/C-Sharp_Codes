/******************************************************************************

Kauan Guilherme Apolinário Costa Camargo N°15 1°A-TI
RA: 20210065

Fazer um pgm em C# para exibir a tabuada.

O usuário deverá informar o nome e qual a tabuada ele quer ver (tabuada do 2, do 3, etc)

O pgm deverá exibir na tela a tabuada escolhida (multiplicando de 1 a 10) com os valores.

Exemplo:
3x1 = 3
3x2 = 6
3x3 = 9
e assim até 3x10 = 30

*******************************************************************************/
using System;
class Tabuada
{
    static void Perfumaria()
    {
    
        Console.ForegroundColor = ConsoleColor.Red;   
        Console.WriteLine("§=========================================§");
        Console.ResetColor();
    }
    
    static int Mult(int y, int z)
    {
     int Multiplicação = (y*z);
     
     return Multiplicação;
    } 
    
  static void Main() 
  {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("             <<< Tabuadas >>>\n");
    Console.ResetColor();
    
    Perfumaria();
    Console.Write("\nDigite seu nome: ");
    string nome = Console.ReadLine().ToLower();
    Console.WriteLine("\nOlá "+nome+" seja bem vindo(a) ao sistema!\n ");
    
    Console.WriteLine("Digite \"999\" para pausar a execucão");
    int num;
    
    do 
    {
    Console.Write("\nQuer ver a tabuada de qual numero?: ");
    num = Convert.ToInt32(Console.ReadLine());
    
    if(num==999)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nPrograma finalizado!");
        Console.ResetColor();
        Perfumaria();
    }
    else if(num!=999)
    {
    Console.Clear();
    Perfumaria();
    for(int x=1;x<=10;x++)
    {
        
        int armaz_met = Mult(num,x);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n"+num+" x "+x+"="+armaz_met);
        Console.ResetColor();
    } 
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\nDigite \"999\" para pausar a execucão");
    Console.ResetColor();
    Perfumaria();
    }
    
    }while(num!=999);
  }
}


