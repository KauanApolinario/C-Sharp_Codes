/******************************************************************************

Kauan Guilherme Apolinário Costa Camargo N°15 1°A-TI
RA: 20210065

*******************************************************************************/
using System;
class At_Basica 
{
    static void Perfumaria()
    {
       Console.ForegroundColor = ConsoleColor.Red;
       Console.WriteLine("§=========================================§");
       Console.ResetColor();
    }
    
  static void Main() 
  {
    string nome_loja="X & Y";
    
    Console.WriteLine("\nBem vindo ao sistema de cadastro de clientes\n");
    
    
    Console.Write("Digite o nome do cliente: ");
    string nome = Console.ReadLine();
    
    Console.Write("\nDigite sua idade: ");
    int idade = Convert.ToInt32 (Console.ReadLine());
    
    Console.Write("\nDigite o numero do Cartao: ");
    int CPF = Convert.ToInt32 (Console.ReadLine());
    
    Console.Write("\nDigite o numero do RG: ");
    int RG = Convert.ToInt32 (Console.ReadLine());
    
    Console.Write("\nDigite seu endereço: ");
    string endereço = Console.ReadLine();
    
    //============================================================//
    Console.Clear();
    Perfumaria();
    
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\n        Confirmação de dados!!!\n");
    Console.ResetColor();
    
    Console.WriteLine("        Nome: "+nome+"\n        Idade: "+idade+"\n        Cartao: "+CPF+"\n        RG: "+RG+"\n        Endereço: "+endereço+"\n");
    
    Perfumaria();
    
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\nCadastro concluido com sucesso!\n");
    

    Console.WriteLine("Seja bem vindo(a) a loja "+nome_loja+" "+nome+"!!");
    
  }
}
