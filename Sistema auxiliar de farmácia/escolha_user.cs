using System;
using System.IO;
class escolhauser
{
    confg obj_config = new confg();
    metodos obj_farm = new metodos();
    cadastro obj_cadastro = new cadastro();
    entrar obj_entrar = new entrar();
    
    public void Escolha_user()
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
            Console.Write("Entrar\n");
            obj_farm.Corsinha("2");
            Console.Write("Cadastrar-se\n");
            obj_farm.Corsinha("3");
            Console.Write("Configurações\n");
            obj_farm.Corsinha("4");
            Console.Write("sair\n");
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
                            Console.Write(" Senha: ");
                            string senha_user = Console.ReadLine();
                            string senha_cadastradas=dados_do_arquivo.Substring(12,4);
                            Console.Write(senha_cadastradas);
                            if(senha_user == senha_cadastradas)
                            {
                                obj_entrar.Entrar(cpf_user);
                            }
                        }
                    }
                }
            }
            else if(escolha=="2")
            {
                obj_cadastro.Cadastro();
            }
            else if(escolha=="3")
            {
                escolha = obj_config.Config();
            }
            else if(escolha=="4")
            {
                Console.Clear();
                obj_farm.Perfumaria(txt_entrar);
                escolha="4";
                Console.WriteLine(" Obrigado pela preferencia.\n Volte sempre!!");
                Console.ReadLine();
                Console.Clear();
            }
            else if(escolha=="adm")
            {
                string cpf_user="11122233344";
                obj_entrar.Entrar(cpf_user);
            }
            else
            {
                Console.Clear();
                obj_farm.Perfumaria(txt_entrar);
                Console.WriteLine(" opção invalida");
                Console.WriteLine(" De enter para voltar");
                ab = Console.ReadLine();
            }
            Console.Clear();
            cont=2;
        }
    }
}