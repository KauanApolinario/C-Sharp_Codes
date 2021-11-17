using System;
using System.IO;
class registraition
{
    metodos obj_farm = new metodos();
    login obj_entrar = new login();
    public void Registraition()
    {
        string dados_user_arquivo = @"Dados_User.txt";
        string txt = "Drugstore registration";
        string confirmacao="a";
        int ap=0;
        do
        {
            Console.Clear();
            obj_farm.Perfumaria(txt);
         
            if(!File.Exists(dados_user_arquivo))
            {
                string texto = "CPF; Senha; Palavra chave; Nome; RG; CEP; Telefone; Data de nascimento;\n";
                File.WriteAllText(dados_user_arquivo,texto);
            }
            else
            {
                string[] lines = File.ReadAllLines("Dados_User.txt");
                Console.Write("\n Name :");
                string nome_user = Console.ReadLine().ToLower();
                
                Console.Write(" CPF :");
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
                        Console.Write(" RG :");
                        string rg_user = Console.ReadLine().ToLower();
                     
                        Console.Write(" CEP :");
                        string cep_user = Console.ReadLine().ToLower();
                        
                        Console.Write(" Phone :");
                        string telefone_user = Console.ReadLine().ToLower();
                        
                        Console.Write(" Date of birth (dd/mm/yyyy): ");
                        string data_nasc_user = Console.ReadLine().ToLower();
                     
                        string senha_user="a";
                        string confirmacao_user="a";
                        
                        do
                        {
                            Console.Write(" 4-digit password: ");
                            senha_user = Console.ReadLine().ToLower();
                            Console.Write(" Confirm the password: ");
                            confirmacao_user = Console.ReadLine().ToLower();
                            if(senha_user!=confirmacao_user || confirmacao_user.Length<4 || confirmacao_user.Length>4)
                            {
                                Console.Clear();
                                obj_farm.Perfumaria(txt);
                                Console.WriteLine();
                                Console.WriteLine(" Name :"+ nome_user);
                                Console.WriteLine(" CPF :"+cpf_user);
                                Console.WriteLine(" RG :"+rg_user);
                                Console.WriteLine(" CEP :"+cep_user);
                                Console.WriteLine(" Phone :"+telefone_user);
                                Console.WriteLine(" Date of birth: "+data_nasc_user);
                                Console.WriteLine(" The confirmation and the password must match!");
                                Console.WriteLine(" And must contain 4 digits.");
                            }
                            
                        }while(senha_user!=confirmacao_user || senha_user.Length<4 || senha_user.Length>4);
                            
                        string palavra_chave_user = "a";
                        do
                        {
                                Console.Clear();
                                obj_farm.Perfumaria(txt);
                                Console.WriteLine();
                                Console.WriteLine(" Name :"+ nome_user);
                                Console.WriteLine(" CPF :"+cpf_user);
                                Console.WriteLine(" RG :"+rg_user);
                                Console.WriteLine(" CEP :"+cep_user);
                                Console.WriteLine(" Phone :"+telefone_user);
                                Console.WriteLine(" Date of birth: "+data_nasc_user);
                                Console.WriteLine(" Password: ****");
                                Console.WriteLine(" Confirmation: ****");
                                Console.Write(" 6-digit keyword: ");
                                palavra_chave_user = Console.ReadLine().ToLower();
                                
                        }while(palavra_chave_user.Length!=6);
                         
                        string dados_user = string.Concat(cpf_user,";",senha_user,";",palavra_chave_user,";",nome_user,";",rg_user,";",cep_user,";",telefone_user,";",data_nasc_user,";\n");
                        
                        Console.Clear();
                        obj_farm.Perfumaria(txt);
                        Console.WriteLine(" Press enter to proceed.");
                        
                        File.AppendAllText(dados_user_arquivo,dados_user);
                        confirmacao="b";
                        obj_entrar.Login(cpf_user);
                    }
                    else
                    {
                        Console.Clear();
                        obj_farm.Perfumaria(txt);
                        Console.WriteLine(" This CPF is already registered, insert one that has not been registered yet.");
                        Console.Write("\n Press enter to go back!");
                        Console.ReadLine();
                    }
                }
                else if((cpf_user.Length<10)||(cpf_user.Length>11))
                {
                    Console.WriteLine(" Invalid CPF!");
                    Console.WriteLine(" Be sure to enter only 11 numbers.");
                    Console.Write(" Press enter to go back.");
                    Console.ReadLine();
                }
            }
        }while(confirmacao=="a");
    }
}