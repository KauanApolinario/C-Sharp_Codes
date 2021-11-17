using System;
using System.IO;
class login
{
    
    public void Login(string cpf)
    {
        string texto ="\t     Drogaria Só Remédio";
        //metodos:
        escolhauser obj_escolha = new escolhauser();
        methods obj_farm = new methods();
        
        string resposta_user="a";
        do
        {
            Console.Clear();
            obj_farm.Perfumaria(texto);
            obj_farm.Corsinha("1");
            Console.WriteLine("Buy medicine");
            obj_farm.Corsinha("2");
            Console.WriteLine("Search about the medicine");
            obj_farm.Corsinha("3");
            Console.WriteLine("Medicine recommendation");
            obj_farm.Corsinha("4");
            Console.WriteLine("Consult overweight");
            obj_farm.Corsinha("5");
            Console.WriteLine("Schedule an appointment");
            obj_farm.Corsinha("6");
            Console.WriteLine("schedule vaccine");
            obj_farm.Corsinha("7");
            Console.WriteLine("Create Card");
            obj_farm.Corsinha("8");
            Console.WriteLine("Return");
            Console.Write("  -");
            resposta_user = Console.ReadLine().ToLower();
            if(resposta_user=="1")
            {
                Console.Clear();
                string txt = "\t Buy medicine";
                obj_farm.Perfumaria(txt);
                obj_farm.Compra_de_remedio(cpf);
            }
            else if(resposta_user=="2")
            {
                Console.Clear();
                string txt = "\tSearch about the medicine";
                obj_farm.Perfumaria(txt);
                obj_farm.Bula(cpf);
            }
            else if(resposta_user=="3")
            {
                Console.Clear();
                string txt = "\t Medicine recommendation";
                obj_farm.Perfumaria(txt);
                obj_farm.Rec_remed(cpf);
            }
            else if(resposta_user=="4")
            {
                Console.Clear();
                string txt = "\t       Calculate the body mass index";
                obj_farm.Perfumaria(txt);
                obj_farm.Imc();
            }
            else if(resposta_user=="5")
            {
                Console.Clear();
                string txt = "\t       Schedule an appointment";
                obj_farm.Perfumaria(txt);
                obj_farm.AgendamentoDeConsulta();
            }
            else if(resposta_user=="6")
            {
                Console.Clear();
                string txt = "\t       Schedule vaccine";
                obj_farm.Perfumaria(txt);
                obj_farm.AgendamentoDevacina();
            }
            else if(resposta_user=="7")
            {
                Console.Clear();
                string txt = "\t       Create Card";
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
                Console.WriteLine(" invalid option");
                Console.WriteLine(" Press enter to go back");
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