/******************************************************************************

Kauan Guilherme Apolinário Costa Camargo n°15 1°a - TI

*******************************************************************************/
using System;
class Eq_seg_grau 
{
    static void Perfumaria()
    {
    
        Console.ForegroundColor = ConsoleColor.Yellow;   
        Console.WriteLine("§============================================§");
        Console.ResetColor();
    }
    
  static void Main() 
  {
    Console.Clear();
    Perfumaria();
    Console.WriteLine("\n Resolva Equações do 2° Grau!!");
    
    
    
    
    
    Console.WriteLine("\n Fórmula: a.x² + b.x +c ");
    Perfumaria();
    
    Console.ForegroundColor = ConsoleColor.Yellow; 
    Console.Write("\n ● ");
    Console.ResetColor();
    Console.Write(" Digite o valor de a: ");
    
    Console.ForegroundColor = ConsoleColor.Yellow; 
    double a = Convert.ToDouble(Console.ReadLine());
    Console.ResetColor();
    
    
    
    Console.ForegroundColor = ConsoleColor.Yellow; 
    Console.Write("\n ● ");
    Console.ResetColor();
    Console.Write(" Digite o valor de b: ");
    
    Console.ForegroundColor = ConsoleColor.Yellow; 
    double b = Convert.ToDouble(Console.ReadLine());
    Console.ResetColor();
    
    
    
    Console.ForegroundColor = ConsoleColor.Yellow; 
    Console.Write("\n ●");
    Console.ResetColor();
    Console.Write(" Digite o valor de c: ");
    
    Console.ForegroundColor = ConsoleColor.Yellow;
    double c = Convert.ToDouble(Console.ReadLine());
    Console.ResetColor();
    
    
    Console.Clear();
    
    
    Perfumaria();
    double delta = b*b-4*a*c;
    Console.WriteLine(" Delta = {0}",delta);
    
    
    
    double raiz_de_delta = Math.Sqrt(delta);
    
    
    
    double XI = (-b+raiz_de_delta)/(2*a);
    double XII = (-b-raiz_de_delta)/(2*a);



    Console.WriteLine("\n X' = {0} \t\t  X\" = {1}",XI,XII);
    Perfumaria();
    

  }
}
