/******************************************************************************

Kauan Guilherme Apolinário Costa Camargo N°15 TI-1A
RA: 20210065

*******************************************************************************/
using System;
class Veículos 
{
    static void Perfumaria()
    {
        Console.WriteLine("§=========================================§");
    }
    
    
    static void Tabela()
    {
        Console.WriteLine("Tabela com alguns códigos prontos:\n");
        Console.WriteLine("         | Código | Fabricante |  ");
        Console.WriteLine("         |   C    | Chevrolet  |  ");
        Console.WriteLine("         |   F    | Fiat       |  ");
        Console.WriteLine("         |   V    | Volkswagen |  ");
    }
    
    string fabr,fabr_c="Chevrolet",fabr_f="Fiat",fabr_v="Volkswagen",mod,cor;
    
    int ano;
    
  static void Main() 
  {
    Perfumaria();
    Tabela();
    Perfumaria();
    
    Console.WriteLine("\nCadastro de Veículos Usados!\n");
    
    Veículos obj_carros = new Veículos();
    
    do 
    {
        Console.WriteLine("\nDigite \"XX\" para pausar a execucão!\n");
        Console.Write("\nDigite o Fabricante: ");
        obj_carros.fabr = Console.ReadLine().ToUpper();
        
    
    if (obj_carros.fabr=="XX")
    {
        Console.WriteLine("\nPrograma finalizado!");
        Perfumaria();
    }
    else if (obj_carros.fabr!="XX")
    {
        Console.Write("\nDigite o modelo: ");
        obj_carros.mod = Console.ReadLine();
    
        Console.Write("\nDigite a cor: ");
        obj_carros.cor = Console.ReadLine();
    
        Console.Write("\nDigite o ano: ");
        obj_carros.ano = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        
        Console.WriteLine("\nConfirmação de dados!\n");
    
    if(obj_carros.fabr=="C")
    {
        Console.WriteLine("Fabricante: "+obj_carros.fabr_c.ToLower());
        Console.WriteLine("\nModelo: "+obj_carros.mod.ToLower());
        Console.WriteLine("\nCor: "+obj_carros.cor.ToLower());
        Console.WriteLine("\nAnuidade: "+obj_carros.ano);
        Perfumaria();
    }
    
    else if(obj_carros.fabr=="F")
    {
        Console.WriteLine("Fabricante: "+obj_carros.fabr_f.ToLower());
        Console.WriteLine("\nModelo: "+obj_carros.mod.ToLower());
        Console.WriteLine("\nCor: "+obj_carros.cor.ToLower());
        Console.WriteLine("\nAnuidade: "+obj_carros.ano);
        Perfumaria();
    }
    
    else if(obj_carros.fabr=="V")
    {
        Console.WriteLine("Fabricante: "+obj_carros.fabr_v.ToLower());
        Console.WriteLine("\nModelo: "+obj_carros.mod.ToLower());
        Console.WriteLine("\nCor: "+obj_carros.cor.ToLower());
        Console.WriteLine("\nAnuidade: "+obj_carros.ano);
        Perfumaria();
    }
    
    else
    {
        Console.WriteLine("Fabricante: "+obj_carros.fabr.ToLower());
        Console.WriteLine("\nModelo: "+obj_carros.mod.ToLower());
        Console.WriteLine("\nCor: "+obj_carros.cor.ToLower());
        Console.WriteLine("\nAnuidade: "+obj_carros.ano);
        Perfumaria();
    }
    
    }
    
    }while(obj_carros.fabr!="XX");
  }
}




