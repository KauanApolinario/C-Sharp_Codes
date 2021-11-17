using System;
using System.IO;
class cadastro
{
    metodos obj_farm = new metodos();
    entrar obj_entrar = new entrar();
    public void Cadastro()
    {
        string dados_user_arquivo = @"Dados_User.txt";
        string txt = "Cadastro Drogaria Só Remédio";
        string confirmacao="a";
        string texto ="a";
        int ap=0;
        do
        {
        
            Console.Clear();
            obj_farm.Perfumaria(txt);
            
            if(!File.Exists(dados_user_arquivo))
            {
               texto = "CPF; Senha; Palavra chave; Nome; RG; CEP; Telefone; Data de nascimento;\n";
               File.WriteAllText(dados_user_arquivo,texto);
            }
            else
            {
                string[] lines = File.ReadAllLines("Dados_User.txt");
                Console.Write("\n Nome: ");
                string nome_user = Console.ReadLine().ToLower();
                
                Console.Write(" CPF: ");
                string cpf_user = Console.ReadLine().ToLower();
                if(cpf_user.Length==11)
                {
                    for(int i=0;i<lines.Length;i++)
                    {
                        string dados_do_arquivo = lines[i];
                        string Cpfs_cadastrados = dados_do_arquivo.Substring(0,11);
                        if(cpf_user==Cpfs_cadastrados)
                        {
                            ap=1;
                        }
                    }
                    if(ap==0)
                    {
                        Console.Write(" RG: ");
                        string rg_user = Console.ReadLine().ToLower();
                     
                        Console.Write(" CEP: ");
                        string cep_user = Console.ReadLine().ToLower();
                        
                        Console.Write(" Telefone: ");
                        string telefone_user = Console.ReadLine().ToLower();
                        
                        Console.Write(" Data de nascimento\n Formato ddmmaaaa: ");
                        string data_nasc_user = Console.ReadLine().ToLower();
                     
                        string senha_user="a";
                        string confirmacao_user="a";
                        
                        do
                        {
                            Console.Write(" Senha com 4 digitos: ");
                            senha_user = Console.ReadLine().ToLower();
                            Console.Write(" Confirmação: ");
                            confirmacao_user = Console.ReadLine().ToLower();
                            if(senha_user!=confirmacao_user || confirmacao_user.Length<4 || confirmacao_user.Length>4)
                            {
                                Console.Clear();
                                obj_farm.Perfumaria(txt);
                                Console.WriteLine();
                                Console.WriteLine(" Nome: "+ nome_user);
                                Console.WriteLine(" CPF: "+cpf_user);
                                Console.WriteLine(" RG: "+rg_user);
                                Console.WriteLine(" CEP: "+cep_user);
                                Console.WriteLine(" Telefone: "+telefone_user);
                                Console.WriteLine(" Data de nascimento: "+data_nasc_user);
                                Console.WriteLine(" A confirmação e a senha tem que serem iguais!");
                                Console.WriteLine(" E devem conter 4 digitos.");
                            }
                            
                        }while(senha_user!=confirmacao_user || senha_user.Length<4 || senha_user.Length>4);
                        string palavra_chave_user = "a";
                        do
                        {
                                Console.Clear();
                                obj_farm.Perfumaria(txt);
                                Console.WriteLine();
                                Console.WriteLine(" Nome: "+ nome_user);
                                Console.WriteLine(" CPF:"+cpf_user);
                                Console.WriteLine(" RG: "+rg_user);
                                Console.WriteLine(" CEP: "+cep_user);
                                Console.WriteLine(" Telefone: "+telefone_user);
                                Console.WriteLine(" Data de nascimento: "+data_nasc_user);
                                Console.WriteLine(" Senha: ****");
                                Console.WriteLine(" Confirmação :****");
                                Console.Write(" Palavra chave\n Com 6 digitos: ");
                                palavra_chave_user = Console.ReadLine().ToLower();
                                
                        }while(palavra_chave_user.Length!=6);
                        
                        string dados_user = string.Concat(cpf_user,";",senha_user,";",palavra_chave_user,";",nome_user,";",rg_user,";",cep_user,";",telefone_user,";",data_nasc_user,";\n");
                        
                        Console.Clear();
                        obj_farm.Perfumaria(txt);
                        Console.WriteLine(" De enter para proseguir.");
                     
                        File.AppendAllText(dados_user_arquivo,dados_user);
                        confirmacao="b";
                        obj_entrar.Entrar(cpf_user);
                    }
                    else
                    {
                        Console.Clear();
                        obj_farm.Perfumaria(txt);
                        Console.WriteLine(" CPF já cadastrado, Prfv insira um que não foi cadastrado ainda");
                        Console.Write("\n De enter para voltar!");
                        Console.ReadLine();
                    }
                }
                else if((cpf_user.Length<10)||(cpf_user.Length>11))
                {
                    Console.WriteLine(" CPF Invalido!");
                    Console.WriteLine(" Certifique-se que digitou apenas os 11 numeros.");
                    Console.Write(" De enter para voltar.");
                    Console.ReadLine();
                }
            }
        }while(confirmacao=="a");
        
    }
}