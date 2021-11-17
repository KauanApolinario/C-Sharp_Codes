using System;
using System.IO;
class entrar
{
    
    public void Entrar(string cpf)
    {
        string texto ="\t     Drogaria Só Remédio";
        //metodos:
        escolhauser obj_escolha = new escolhauser();
        metodos obj_farm = new metodos();
        
        string resposta_user="a";
        do
        {
            Console.Clear();
            obj_farm.Perfumaria(texto);
            obj_farm.Corsinha("1");
            Console.WriteLine("Comprar remedio");
            obj_farm.Corsinha("2");
            Console.WriteLine("Pesquisar sobre o remedio");
            obj_farm.Corsinha("3");
            Console.WriteLine("Recomendação de remedio");
            obj_farm.Corsinha("4");
            Console.WriteLine("Consultar IMC");
            obj_farm.Corsinha("5");
            Console.WriteLine("Agendar consulta");
            obj_farm.Corsinha("6");
            Console.WriteLine("Agendar vacina");
            obj_farm.Corsinha("7");
            Console.WriteLine("Criar Cartão");
            obj_farm.Corsinha("8");
            Console.WriteLine("Voltar");
            Console.Write("  -");
            resposta_user = Console.ReadLine().ToLower();
            if(resposta_user=="1")
            {
                Console.Clear();
                string txt = "\t Comprar remedio";
                obj_farm.Perfumaria(txt);
                obj_farm.Compra_de_remedio(cpf);
            }
            else if(resposta_user=="2")
            {
                Console.Clear();
                string txt = "\tPesquisar sobre o remedio";
                obj_farm.Perfumaria(txt);
                obj_farm.Bula(cpf);
            }
            else if(resposta_user=="3")
            {
                Console.Clear();
                string txt = "\t Recomendação de remedio";
                obj_farm.Perfumaria(txt);
                obj_farm.Rec_remed(cpf);
            }
            else if(resposta_user=="4")
            {
                Console.Clear();
                string txt = "\t       Calculando IMC";
                obj_farm.Perfumaria(txt);
                obj_farm.Imc();
            }
            else if(resposta_user=="5")
            {
                Console.Clear();
                string txt = "\t       Agendar consulta";
                obj_farm.Perfumaria(txt);
                obj_farm.AgendamentoDeConsulta();
            }
            else if(resposta_user=="6")
            {
                Console.Clear();
                string txt = "\t       Agendar vacina";
                obj_farm.Perfumaria(txt);
                obj_farm.AgendamentoDevacina();
            }
            else if(resposta_user=="7")
            {
                Console.Clear();
                string txt = "\t       Criar Cartão";
                obj_farm.Perfumaria(txt);
                obj_farm.Criar_cartao();
            }
            else if(resposta_user=="8")
            {
                Console.Clear();
                obj_farm.Perfumaria(texto);
                
            }
            else
            {
                Console.Clear();
                obj_farm.Perfumaria(texto);
                Console.WriteLine(" opção invalida");
                Console.WriteLine(" De enter para voltar");
                Console.ReadLine();
            }
        }while(resposta_user!="8");
    }
    public void Perfumariadois(string txt_texto)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" »»------------------------------------------««");
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("     "+txt_texto);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" »»------------------------------------------««");
        Console.ForegroundColor = ConsoleColor.Black;
    }
    
}