using System;
using System.IO;
class choiceuser
{
    conf obj_config = new conf();
    methods obj_farm = new methods();
    registraition obj_registraition = new registraition();
    login obj_login = new login();
    
    public string Choiceuser()
    {
        string txt_entrar = "\t     Drogaria Só Remédio";
        string[] lines = File.ReadAllLines("Dados_User.txt");
        string ab="a";
        int cont = 1;
        string escolha="a";
        while(escolha !="4")
        {
            if(cont==2)
            {
                obj_farm.Perfumaria(txt_entrar);
            }
        Console.Write("\n");
        obj_farm.Corsinha("1");
        Console.Write("To enter\n");
        obj_farm.Corsinha("2");
        Console.Write("Register\n");
        obj_farm.Corsinha("3");
        Console.Write("Settings\n");
        obj_farm.Corsinha("4");
        Console.Write("Exit\n");
        Console.Write("  -");
        escolha = Console.ReadLine().ToLower();
        if(escolha=="1")
        {
            Console.Clear();
            obj_farm.Perfumaria(txt_entrar);
            Console.Write(" CPF: ");
            string cpf_user = Console.ReadLine();
            if(cpf_user.Length==11)
            {
                for(int i=0;i<lines.Length;i++)
                {
                    string dados_do_arquivo = lines[i];
                    string Cpfs_cadastrados = dados_do_arquivo.Substring(0,11);
                    
                    if(cpf_user==Cpfs_cadastrados)
                    {
                        Console.Write(" Password: ");
                        string senha_user = Console.ReadLine();
                        string senha_cadastradas=dados_do_arquivo.Substring(12,4);
                        Console.Write(senha_cadastradas);
                        if(senha_user == senha_cadastradas)
                        {
                            obj_login.Login(cpf_user);
                        }
                    }
                }
            }
        }
        else if(escolha=="2")
        {
            obj_registraition.Registraition();
        }
        else if(escolha=="3")
        {
            escolha=obj_config.Conf();
        }
        else if(escolha=="4")
        {
            Console.Clear();
            obj_farm.Perfumaria(txt_entrar);
            escolha="4";
            Console.WriteLine(" Thank you for your preference.\n Check back often!!");
            Console.ReadLine();
            Console.Clear();
            return("4");
        }
        else if(escolha=="adm")
        {
            string cpf_user="11122233344";
            obj_login.Login(cpf_user);
        }
        else
        {
            Console.Clear();
            obj_farm.Perfumaria(txt_entrar);
            Console.WriteLine(" Invalid option!");
            Console.WriteLine(" Press enter to go back.");
            ab = Console.ReadLine();
        }
        Console.Clear();
        cont=2;
        }
        return("0");
    }
}