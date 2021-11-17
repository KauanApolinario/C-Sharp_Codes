using System;
using System.IO;
class confg
{
    choiceuser obj_idioma = new choiceuser();
    metodos obj_metodos = new metodos();
    public string Config()
    {
        string texte = "\t     Drogaria Só Remédio";
        Console.Clear();
        string txte = "\t\tConfigurações";
        string txt_entrar = "\t     Drogaria Só Remédio";
        obj_metodos.Perfumaria(txte);
        try
        {
            Console.WriteLine(" O que você deseja modificar?");
            obj_metodos.Corsinha("1");
            Console.WriteLine("Idioma");
            obj_metodos.Corsinha("2");
            Console.WriteLine("Sobre");
            Console.Write("  -");
            int escolha_confg = Convert.ToInt32(Console.ReadLine());
            if(escolha_confg == 1)
            {
                Console.Clear();
                string texto= "\tConfigurações de idiomas";
                obj_metodos.Perfumaria(texto);
                Console.WriteLine(" Idiomas disponiveis: ");
                obj_metodos.Corsinha("1");
                Console.WriteLine("Português");
                obj_metodos.Corsinha("2");
                Console.WriteLine("inglês");
                Console.Write("  -");
                string escolha_idioma = Console.ReadLine();
                if(escolha_idioma=="1")
                {
                    Console.Clear();
                }
                else if(escolha_idioma=="2")
                {
                    Console.Clear();
                    obj_metodos.Perfumaria(texte);
                    string a = obj_idioma.Choiceuser();
                    return(a);
                }
                else
                {
                    Console.WriteLine(" opção invalida");
                    Console.WriteLine(" De enter para voltar");
                    Console.ReadLine();
                }
            }
            else if(escolha_confg==2)
            {
                Console.Clear();
                obj_metodos.Perfumaria(txt_entrar);
                obj_metodos.Sobre();
            }
            else
            {
                Console.WriteLine(" opção invalida");
                Console.WriteLine(" De enter para voltar");
                Console.ReadLine();
                
            }
        }
        catch(Exception e)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\t *Erro! *");
            Console.WriteLine("\t"+e.Message);
        }
        return("0");
    }
}