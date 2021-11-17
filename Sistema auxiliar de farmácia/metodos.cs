//metodos usados ao longo do programa
using System;
using System.IO;
class metodos
{
    entrar obj_entrar = new entrar();
    public string txt = "\t Recomendação de remedio";
    public string txt_1 = "\t\t Compra de Remedio ";
    public string txt_2 = "\t\t Consulta Bula ";
    
    enum bula
    {
        cabeca,
        garganta,
        ouvido,
        musculos,
        estomago,
        dente
    }
    public void Perfumaria(string texto)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" »»------------------------------------------««");
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("     "+texto);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" »»------------------------------------------««");
        Console.ForegroundColor = ConsoleColor.Black;
    }
    public void Rec_remed(string cpf)
    {
        Console.WriteLine(" Escolha qual sintoma você está sentindo");
        Corsinha("1");
        Console.Write(" Dores na região da cabeça\n");
        Corsinha("2");
        Console.Write(" Dores na região da garganta\n");
        Corsinha("3");
        Console.Write(" Dores na região do ouvido\n");
        Corsinha("4");
        Console.Write(" Dores nos musculos\n");
        Corsinha("5");
        Console.Write(" Dores na região do estomago\n");
        Corsinha("6");
        Console.Write(" Dores na região do dente\n");
        Console.Write(" -");
        string escolha ="0";
        escolha = Console.ReadLine();
        if(escolha=="1")
        {
            Console.Clear();
            obj_entrar.Perfumariadois(txt);
            bula meu_remedio = bula.cabeca;
            Console.WriteLine(" os remedios mais recomendados\n para dor de "+meu_remedio+" são: \n");
            Console.Write(" | ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Analgésicos");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" | ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Anti-inflamatórios");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" |\n");
            Console.WriteLine(" | Paracetamol |     Ibuprofeno     |");
            Console.WriteLine(" |   dipirona  |      Advil         |");
            Console.WriteLine(" |   Tylenol   |     Ibupril        |");
            Console.WriteLine(" |  Novalgina  |    diclofenaco     |");
            escolha = "sim";
        }
        else if(escolha=="2")
        {
            Console.Clear();
            obj_entrar.Perfumariadois(txt);
            bula meu_remedio = bula.garganta;
            Console.WriteLine(" Os remedios mais recomendados\n para dor de "+meu_remedio+" são:\n ");
            Console.Write(" | ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Analgésicos");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" | ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Anti-inflamatórios");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" |\n");
    
            Console.WriteLine(" | Paracetamol |     Ibuprofeno     |");
            Console.WriteLine(" |   dipirona  |      Advil         |");
            Console.WriteLine(" |   Tylenol   |     Ibupril        |");
            Console.WriteLine(" |  Novalgina  |    diclofenaco     |");
            escolha = "sim";
        }
        else if(escolha=="3")
        {
            Console.Clear();
            obj_entrar.Perfumariadois(txt);
            bula meu_remedio = bula.ouvido;
            Console.WriteLine(" Os remedios mais recomendados\n para dor de "+meu_remedio+" são: \n");
            Console.Write(" | ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Analgésicos");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" | ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Anti-inflamatórios");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" |\n");
    
            Console.WriteLine(" | Paracetamol |     Ibuprofeno     |");
            Console.WriteLine(" |   dipirona  |      Advil         |");
            Console.WriteLine(" |   Tylenol   |     Ibupril        |");
            Console.WriteLine(" |  Novalgina  |    diclofenaco     |");
            escolha = "sim";
        }
        else if(escolha=="4")
        {
            Console.Clear();
            obj_entrar.Perfumariadois(txt);
            bula meu_remedio = bula.musculos;
            Console.WriteLine(" Os remedios mais recomendados\n para dor nos "+meu_remedio+" são: \n");
            Console.Write(" | ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Analgésicos");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" | ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Anti-inflamatórios");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" |\n");
    
            Console.WriteLine(" | Paracetamol |     Ibuprofeno     |");
            Console.WriteLine(" |   dipirona  |      Advil         |");
            Console.WriteLine(" |   Tylenol   |     Ibupril        |");
            Console.WriteLine(" |  Novalgina  |    diclofenaco     |");
            escolha = "sim";
        }
        else if(escolha=="5")
        {
            Console.Clear();
            obj_entrar.Perfumariadois(txt);
            bula meu_remedio = bula.estomago;
            Console.Write(" Os remedios mais recomendados\n para dor de "+meu_remedio+" são:\n ");
            Console.WriteLine("\n\n");
            Console.Write(" | ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("      Antiácidos     ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("  | ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("   Inibidores da  ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("  |\n");
            Console.Write(" | ");
            Console.Write("                     ");
            Console.Write("  | ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" produçao de ácido");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("  |\n");
            Console.WriteLine(" | hidróxido de alumínio  |      Pepsamar       |");
            Console.WriteLine(" | hidróxido de magnésio  |       Maalox        |");
            Console.WriteLine(" |     Estomazil          |     esomeprazol     |");
            escolha = "sim";
        }
        else if(escolha=="6")
        {
            Console.Clear();
            obj_entrar.Perfumariadois(txt);
            bula meu_remedio = bula.dente;
            Console.WriteLine(" Os remedios mais recomendados\n para dor de "+meu_remedio+" são:\n ");
            Console.Write(" | ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Analgésicos");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" | ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Anti-inflamatórios");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" |\n");
    
            Console.WriteLine(" | Paracetamol |     Ibuprofeno     |");
            Console.WriteLine(" |   dipirona  |      Advil         |");
            Console.WriteLine(" |   Tylenol   |     Ibupril        |");
            Console.WriteLine(" |  Novalgina  |    diclofenaco     |");
            escolha = "sim";
        }
        if(escolha=="sim")
        {
            Console.Write("\n deseja adquirir algum destes remedios");
            Corsinha("sim");
            Console.Write(" ou ");
            Corsinha("nao");
            Console.Write("? ");
            string escolha_comp=Console.ReadLine().ToLower();
            if(escolha_comp=="sim")
            {
                Compra_de_remedio(cpf);
            }
        }
        else
        {
            Console.Clear();
            Console.Write("\n o indice não esta disponivel ou não existe");
            Console.Write("\n De enter para voltar.");
            Console.ReadLine();
        }
    }
    public void Imc()
    {
        Console.Write(" Digite seu peso: ");
        double peso_use = Convert.ToDouble(Console.ReadLine());
        Console.Write(" Digite sua altura em Metros: ");
        double altura_user = Convert.ToDouble(Console.ReadLine());
        double imc_user = peso_use/(altura_user*altura_user);
        double imc=Math.Round(imc_user);
        
        if(imc<=17)
        {
            Console.WriteLine(" Seu IMC é:"+imc+" Você Está com magreza grave");
            Console.WriteLine(" Isso pode causar: ");
            Console.WriteLine(" Insuficiência cardiaca");
            Console.WriteLine(" Anemia grave");
            Console.WriteLine(" Enfraquecimento do sistema imunologico");
        }
        else if(imc>17 & imc<=18.5)
        {
            Console.WriteLine(" Seu IMC é:"+imc+" Você Está com magreza leve");
            Console.WriteLine(" Isso pode causar: ");
            Console.WriteLine("Problemas de saúde ligados a desnutrição");
        }
        else if(imc>18.5 & imc<=24.9)
        {
            Console.WriteLine(" Seu IMC é:"+imc+" Você Está eutrófico");
            Console.WriteLine(" Saudável");
        }
        else if(imc>25 & imc<=29.9)
        {
            Console.WriteLine(" Seu IMC é:"+imc+" Você Está com sobrepeso");
            Console.WriteLine(" Isso pode causar: ");
            Console.WriteLine(" Fadiga");
            Console.WriteLine(" varizes");
            Console.WriteLine(" má circulação");
        }
        else if(imc>30 & imc<=34.9)
        {
            Console.WriteLine(" Seu IMC é:"+imc+" Você Está com Obesidade I");
            Console.WriteLine(" Isso pode causar: ");
            Console.WriteLine(" Diabétes");
            Console.WriteLine(" Infarto");
            Console.WriteLine(" Angina");
            Console.WriteLine(" Aterosclerose");
        }
        else if(imc>35 & imc<=39.9)
        {
            Console.WriteLine(" Seu IMC é:"+imc+" Você Está com Obesidade II");
            Console.WriteLine(" Isso pode causar: ");
            Console.WriteLine(" Falta de ar");
            Console.WriteLine(" Apneia do sono");
        }
        else if(imc>40)
        {
            Console.WriteLine(" Seu IMC é:"+imc+" Você Está com Obesidade III");
            Console.WriteLine(" Isso pode causar: ");
            Console.WriteLine(" Refluxo");
            Console.WriteLine(" Infarto");
            Console.WriteLine(" Avc");
            Console.WriteLine(" Dificuldade de locomoção");
        }
        Console.Write("\n De enter para voltar.");
        Console.ReadLine();
    }
    
    public void AgendamentoDeConsulta()
    {
       Console.WriteLine(" Escolha o posto de saude mais perto da sua casa: "); 
       Corsinha("1");
       Console.WriteLine("Centro de Saúde - Aeroporto");
       Corsinha("2");
       Console.WriteLine("Centro de Saúde - Unidade Oziel");
       Corsinha("3");
       Console.WriteLine("Centro de Saúde - \"Santos Dumont\"");
       Corsinha("4");
       Console.WriteLine("centro de Saúde - Unidade Centro Campinas");
       Corsinha("5");
       Console.WriteLine("Centro de Saúde - Carvalho de Moura");
       Console.Write(" - ");
       string escolha_centrodesaude = Console.ReadLine();
       if(escolha_centrodesaude == "1")
       {
           dia_consulta();
       }
       else if(escolha_centrodesaude == "2")
       {
           dia_consulta();
       }
       else if (escolha_centrodesaude == "3")
       {
           dia_consulta();
       }
       else if(escolha_centrodesaude == "4")
       {
           dia_consulta();
       }
       else if (escolha_centrodesaude == "5")
       {
           dia_consulta();
       }
       else
       {
           Console.Clear();
           string txt = "\t       Agendar consulta";
           obj_entrar.Perfumariadois(txt);
           Console.WriteLine(" Escolha inexistente!");
       }
       Console.WriteLine(" De enter para voltar.");
       Console.ReadLine();
    }
    public void dia_consulta()
    {
        Console.WriteLine(" Qual é o melhor dia para o agendamento?");
        Console.Write(" Digite a data no formato dd/mm : ");
        string data_consulta = Console.ReadLine();
        Console.Clear();
        string txt = "\t       Consulta agendada";
        obj_entrar.Perfumariadois(txt);
        Console.WriteLine(" Sua consulta foi marcada para o dia: "+data_consulta);
        Console.WriteLine(" Com o Dr.Garibaldo");
    }
    public void AgendamentoDevacina()
    {
       Console.WriteLine(" Escolha o posto de saude mais perto da sua casa: ");
       Corsinha("1");
       Console.WriteLine("Centro de Saúde - Aeroporto");
       Corsinha("2");
       Console.WriteLine("Centro de Saúde - Unidade Oziel");
       Corsinha("3");
       Console.WriteLine("Centro de Saúde - \"Santos Dumont\"");
       Corsinha("4");
       Console.WriteLine("Centro de Saúde - Unidade Centro Campinas");
       Corsinha("5");
       Console.WriteLine("Centro de Saúde - Carvalho de Moura");
       Console.Write(" - ");
       string escolha_centrodesaude = Console.ReadLine();
       if(escolha_centrodesaude == "1")
       {
           dia_Vacina();
       }
       else if(escolha_centrodesaude == "2")
       {
           dia_Vacina();
       }
       else if (escolha_centrodesaude == "3")
       {
           dia_Vacina();
       }
       else if(escolha_centrodesaude == "4")
       {
           dia_Vacina();
       }
       else if (escolha_centrodesaude == "5")
       {
           dia_Vacina();
       }
       else
       {
           Console.Clear();
           string txt = "\t       Agendar vacina";
           obj_entrar.Perfumariadois(txt);
           Console.WriteLine(" Escolha inexistente!");
       }
       Console.WriteLine(" De enter para voltar.");
       Console.ReadLine();
    }
    public void dia_Vacina()
    {
        Console.WriteLine(" Qual é o melhor dia para o agendamento?");
        Console.Write(" Digite a data no formato dd/mm : ");
        string data_vacina = Console.ReadLine();
        Console.Clear();
        string txt = "\t       vacina agendada";
        obj_entrar.Perfumariadois(txt);
        Console.WriteLine(" Sua consulta foi marcada para o dia: "+data_vacina);
        Console.WriteLine(" Com a enfermeira Claudia");
    }
     public void Criar_cartao()
    {
        string condicao_de_parada="ap";
        string arquivo_cartoes = @"Cartao_User.txt";
        string existe_cartao ="nao";
        Console.WriteLine("\n para ganhar desconto de 20% digite o CPF \n que foi usado para realizar o cadastro");
        Console.Write(" CPF : ");
        string cpf_user_cartao = Console.ReadLine();
        do
        {
            if(!File.Exists(arquivo_cartoes))
            {
                string texto = "CPF dos usuarios que tem cartão;\n";
                File.WriteAllText(arquivo_cartoes,texto);
            }
            else
            {
                condicao_de_parada="2";
                string[] lines = File.ReadAllLines("Cartao_User.txt");
                for(int i=0;i<lines.Length-1;i++)
                {
                    string cartoes = lines[i];
                    string Cpfs_cadastrados_cartoes = cartoes.Substring(0,11);
                    
                    if(cpf_user_cartao==Cpfs_cadastrados_cartoes)
                    {
                        existe_cartao="sim";
                        Console.Clear();
                        string txt_erro = "\t     Drogaria Só Remédio";
                        obj_entrar.Perfumariadois(txt_erro);
                        Console.WriteLine("\n CPF já cadastrado.\n");
                        Console.Write(" De enter para voltar.");
                        Console.ReadLine();
                    }
                }
            }
        }while(condicao_de_parada=="ap");
        
        if(existe_cartao!="sim")
        {
            Console.Clear();
            string txt = "\t       Catão criado";
            obj_entrar.Perfumariadois(txt);
            Console.WriteLine("\n Encerre a aplicação para o bonus ser aplicado!!\n");
            Console.Write(" De enter para voltar.");
            string dados_user_cartao = string.Concat(cpf_user_cartao,";\n");
            File.AppendAllText(arquivo_cartoes,dados_user_cartao);
            Console.ReadLine();
        }
    }
    public void Compra_de_remedio(string cpf)
    {
        string[] remedio ={" ","patacetamol","dipirona","Tylenol","Novalgina","Pirantel(ascarical)","Ivermectina","Metronidazol","Xarelto","Saxenda","Neosaldina","Ibuprofeno","Advil","Ibupril","Diclofenaco","Omeprazol","benegrip_multi_noite","benegrip_multi_dia","Glifage","Torsilax","Victoza","Anthelios","Puran"};
        double[] preco_remed={0,3.95,2.05,6.19,6.93,9.98,16.84,9.49,103.81,713.98,2.25,5.01,2.79,3.31,3.49,3.70,8.48,8.74,20.95,1.49,22.91,45.00,3.01};
        string[] line = File.ReadAllLines("Dados_User.txt");
        
        string esco = "aa";
        double total = 0;
        string conca= "";
        
        do
        {
            Console.Clear();
            obj_entrar.Perfumariadois(txt_1);
            Console.WriteLine("\n");
            Console.WriteLine(" selecione de acordo com o indice\n o remedio que deseja comprar:");
            Console.WriteLine("\n");
            
            Console.WriteLine(" Remedios................a partir de \n");
            
            Corsinha("1");
            Console.WriteLine("Paracetamol..............R$ "+preco_remed[1]);
            Corsinha("2");
            Console.WriteLine("Dipirona.................R$ "+preco_remed[2]);
            Corsinha("3");
            Console.WriteLine("Tylenol..................R$ "+preco_remed[3]);
            Corsinha("4");
            Console.WriteLine("Novalgina................R$ "+preco_remed[4]);
            Corsinha("5");
            Console.WriteLine("Pirantel(ascarical)......R$ "+preco_remed[5]);
            Corsinha("6");
            Console.WriteLine("Ivermectina..............R$ "+preco_remed[6]);
            Corsinha("7");
            Console.WriteLine("Metronidazol.............R$ "+preco_remed[7]);
            Corsinha("8");
            Console.WriteLine("Xarelto..................R$ "+preco_remed[8]);
            Corsinha("9");
            Console.WriteLine("Saxenda..................R$ "+preco_remed[9]);
            Corsinha("10");
            Console.WriteLine("Neosaldina..............R$ "+preco_remed[10]);
            Corsinha("11");
            Console.WriteLine("Ibuprofeno..............R$ "+preco_remed[11]);
            Corsinha("12");
            Console.WriteLine("Advil...................R$ "+preco_remed[12]);
            Corsinha("13");
            Console.WriteLine("Ibupril.................R$ "+preco_remed[13]);
            Corsinha("14");
            Console.WriteLine("Diclofenaco.............R$ "+preco_remed[14]);
            Corsinha("15");
            Console.WriteLine("Omeprazol...............R$ "+preco_remed[15]);
            Corsinha("16");
            Console.WriteLine("benegrip multi-noite....R$ "+preco_remed[16]);
            Corsinha("17");
            Console.WriteLine("benegrip multi-dia......R$ "+preco_remed[17]);
            Corsinha("18");
            Console.WriteLine("Glifage.................R$ "+preco_remed[18]);
            Corsinha("19");
            Console.WriteLine("Torsilax................R$ "+preco_remed[19]);
            Corsinha("20");
            Console.WriteLine("Victoza.................R$ "+preco_remed[20]);
            Corsinha("21");
            Console.WriteLine("Anthelios...............R$ "+preco_remed[21]);
            Corsinha("22");
            Console.WriteLine("Puran...................R$ "+preco_remed[22]);
            Console.WriteLine("\n");
            Console.Write(" qual remedio voce ira adicionar ao carrinho? ");
           
            int remd = 0;
            try
            {
                string indice = Console.ReadLine().ToLower();
                if(indice.Length<3 && indice!=" ")
                {
                    remd = Convert.ToInt32(indice);
                }
            }
            catch(Exception e)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\t *Erro! *");
                Console.WriteLine("\t"+e.Message);
            }
            
            
            Console.WriteLine("\n");
            
            Console.Clear();
            obj_entrar.Perfumariadois(txt_1);
            Console.Write("\n");
            Console.Write("\n");
            if(remd==1)
            {
               
               Console.WriteLine(" você adicionou ao seu carrinho "+remedio[remd]+" que custa "+preco_remed[remd]);
               total=total+preco_remed[remd];
               conca = string.Concat(conca," ",remedio[remd],"..............",preco_remed[remd],"\n");
               
               
            }
            else if(remd==2)
            {
                Console.Write("\n");
                Console.WriteLine(" você adicionou ao seu carrinho "+remedio[remd]+" que custa "+preco_remed[remd]);
                total=total+preco_remed[remd];
                conca = string.Concat(conca," ",remedio[remd],".................",preco_remed[remd],"\n");
                
            }
            else if(remd==3)
            {
                Console.WriteLine(" você adicionou ao seu carrinho "+remedio[remd]+" que custa "+preco_remed[remd]);
                total=total+preco_remed[remd];
                conca = string.Concat(conca," ",remedio[remd],"..................",preco_remed[remd],"\n");
                
            }
            else if(remd==4)
            {
                Console.WriteLine(" você adicionou ao seu carrinho "+remedio[remd]+" que custa "+preco_remed[remd]);
                total=total+preco_remed[remd];
                conca = string.Concat(conca," ",remedio[remd],"................",preco_remed[remd],"\n");
                
                
            }
            else if(remd==5)
            {
                Console.WriteLine(" você adicionou ao seu carrinho "+remedio[remd]+" que custa "+preco_remed[remd]);
                total=total+preco_remed[remd];
                conca = string.Concat(conca," ",remedio[remd],"......",preco_remed[remd],"\n");
                
            }
            else if(remd==6)
            {
                Console.WriteLine(" você adicionou ao seu carrinho "+remedio[remd]+" que custa "+preco_remed[remd]);
                total=total+preco_remed[remd];
                conca = string.Concat(conca," ",remedio[remd],"..............",preco_remed[remd],"\n");
                
            }
            else if(remd==7)
            {
                Console.WriteLine(" você adicionou ao seu carrinho "+remedio[remd]+" que custa "+preco_remed[remd]);;
                total=total+preco_remed[remd];
                conca = string.Concat(conca," ",remedio[remd],".............",preco_remed[remd],"\n");
                
            }
            else if(remd==8)
            {
                Console.WriteLine(" você adicionou ao seu carrinho "+remedio[remd]+" que custa "+preco_remed[remd]);
                total=total+preco_remed[remd];
                conca = string.Concat(conca," ",remedio[remd],"..................",preco_remed[remd],"\n");
                
            }
            else if(remd==9)
            {
                Console.WriteLine(" você adicionou ao seu carrinho "+remedio[remd]+" que custa "+preco_remed[remd]);
                total=total+preco_remed[remd];
                conca = string.Concat(conca," ",remedio[remd],"..................",preco_remed[remd],"\n");
                
            }
            else if(remd==10)
            {
                Console.WriteLine(" você adicionou ao seu carrinho "+remedio[remd]+" que custa "+preco_remed[remd]);
                total=total+preco_remed[remd];
                conca = string.Concat(conca," ",remedio[remd],"..............",preco_remed[remd],"\n");
                
            }
            else if(remd==11)
            {
                Console.WriteLine(" você adicionou ao seu carrinho "+remedio[remd]+" que custa "+preco_remed[remd]);
                total=total+preco_remed[remd];
                conca = string.Concat(conca," ",remedio[remd],"..............",preco_remed[remd],"\n");
                
            }
            else if(remd==12)
            {
                Console.WriteLine(" você adicionou ao seu carrinho "+remedio[remd]+" que custa "+preco_remed[remd]);
                total=total+preco_remed[remd];
                conca = string.Concat(conca," ",remedio[remd],"...................",preco_remed[remd],"\n");
                
            }
            else if(remd==13)
            {
                Console.WriteLine(" você adicionou ao seu carrinho "+remedio[remd]+" que custa "+preco_remed[remd]);
                total=total+preco_remed[remd];
                conca = string.Concat(conca," ",remedio[remd],".................",preco_remed[remd],"\n");
                
            }
            else if(remd==14)
            {
                Console.WriteLine(" você adicionou ao seu carrinho "+remedio[remd]+" que custa "+preco_remed[remd]);
                total=total+preco_remed[remd];
                conca = string.Concat(conca," ",remedio[remd],".........",preco_remed[remd],"\n");
                
            }
            else if(remd==15)
            {
               Console.WriteLine(" você adicionou ao seu carrinho "+remedio[remd]+" que custa "+preco_remed[remd]);
               total=total+preco_remed[remd];
               conca = string.Concat(conca," ",remedio[remd],"...............",preco_remed[remd],"\n");
            }
            else if(remd==16)
            {
               Console.WriteLine(" você adicionou ao seu carrinho "+remedio[remd]+" que custa "+preco_remed[remd]);
               total=total+preco_remed[remd];
               conca = string.Concat(conca," ",remedio[remd],"....",preco_remed[remd],"\n");
            }
            else if(remd==17)
            {
               Console.WriteLine(" você adicionou ao seu carrinho "+remedio[remd]+" que custa "+preco_remed[remd]);
               total=total+preco_remed[remd];
               conca = string.Concat(conca," ",remedio[remd],"......",preco_remed[remd],"\n");
            }
            else if(remd==18)
            {
               Console.WriteLine(" você adicionou ao seu carrinho "+remedio[remd]+" que custa "+preco_remed[remd]);
               total=total+preco_remed[remd];
               conca = string.Concat(conca," ",remedio[remd],".................",preco_remed[remd],"\n");
            }
            else if(remd==19)
            {
               Console.WriteLine(" você adicionou ao seu carrinho "+remedio[remd]+" que custa "+preco_remed[remd]);
               total=total+preco_remed[remd];
               conca = string.Concat(conca," ",remedio[remd],"................",preco_remed[remd],"\n");
            }
            else if(remd==20)
            {
                Console.WriteLine(" você adicionou ao seu carrinho "+remedio[remd]+" que custa "+preco_remed[remd]);
                total=total+preco_remed[remd];
                conca = string.Concat(conca," ",remedio[remd],".................",preco_remed[remd],"\n");
            }
            else if(remd==21)
            {
                Console.WriteLine(" você adicionou ao seu carrinho "+remedio[remd]+" que custa "+preco_remed[remd]);
                total=total+preco_remed[remd];
                conca = string.Concat(conca," ",remedio[remd],"...............",preco_remed[remd],"\n");
            }
            else if(remd==22)
            {
                Console.WriteLine(" você adicionou ao seu carrinho "+remedio[remd]+" que custa "+preco_remed[remd]);
                total=total+preco_remed[remd];
                conca = string.Concat(conca," ",remedio[remd],"...................",preco_remed[remd],"\n");
            }
            else 
            {
               Console.Write("Por favor indique um indice existente!!\n");
            }
            
            Console.Write("\n\n");
            
            Console.Write(" deseja comprar outro remedio ");
            Corsinha("sim");
            Console.Write(" ou ");
            Corsinha("nao");
            Console.Write("? ");
            esco = Console.ReadLine().ToLower();
            
        }while(esco!="nao");
        Console.Clear();
        
        string esxixte_cadastro="ap";
        for(int i=0;i<line.Length;i++)
        {
            string dados_do_arquivo = line[i];
            string Cpfs_cadastrado = dados_do_arquivo.Substring(0,11);
            if(cpf==Cpfs_cadastrado)
            {
                esxixte_cadastro="sim";
            }
        }
        if(esxixte_cadastro=="sim")
        {
            obj_entrar.Perfumariadois(txt_1);
            Console.Write(" os remedios do seu carrinho são:\n");
            Console.Write("\n");
            Console.Write(conca);
            Console.Write("\n");
            double total_desc=total-(total*0.20);
            Console.Write(" o desconto de");
            Console.ForegroundColor = ConsoleColor.Red; 
            Console.Write("  20%");
            Console.ForegroundColor = ConsoleColor.Black; 
            Console.Write("  por possuir o cartao ja foi aplicado\n\n");
            Console.WriteLine(" o valor total a pagar pela sua compra é: "+total_desc);
            Console.Write("\n");
            Console.Write(" De enter para voltar.");
            Console.ReadLine();  
        }
        else
        {
            obj_entrar.Perfumariadois(txt_1);
            Console.Write(" os remedios do seu carrinho são:\n");
            Console.Write("\n");
            Console.Write(conca);
            Console.Write("\n");
            Console.WriteLine(" o valor total a pagar pela sua compra é: "+total);
            Console.Write("\n");
            Console.Write(" De enter para voltar.");
            Console.ReadLine();  
        }
    }
    public void Bula(string cpf)
    {
        string[] remedio ={" ","patacetamol","dipirona","Tylenol","Novalgina","Pirantel(ascarical)","Ivermectina","Metronidazol","Xarelto","Saxenda","Neosaldina","Ibuprofeno","Advil","Ibupril","Diclofenaco","Omeprazol","benegrip_multi_noite","benegrip_multi_dia","Glifage","Torsilax","Victoza","Anthelios","Puran"};
        double[] preco_remed={0,3.95,2.05,6.19,6.93,9.98,16.84,9.49,103.81,713.98,2.25,5.01,2.79,3.31,3.49,3.70,8.48,8.74,20.95,1.49,22.91,45.01,3.01};
        string resp =" ";
        
        Console.Clear();
        
        do
        {
            
            obj_entrar.Perfumariadois(txt_2);
            Console.Write("\n");
            Console.WriteLine(" selecione de acordo com o indice\n o remedio que deseja consultar a bula:");
            Console.Write("\n");
            
            Console.Write(" Remedios:\n");
            
            Corsinha("1");
            Console.WriteLine("Paracetamol");
            Corsinha("2");
            Console.WriteLine("Dipirona");
            Corsinha("3");
            Console.WriteLine("Tylenol");
            Corsinha("4");
            Console.WriteLine("Novalgina");
            Corsinha("5");
            Console.WriteLine("Pirantel(ascarical)");
            Corsinha("6");
            Console.WriteLine("Ivermectina");
            Corsinha("7");
            Console.WriteLine("Metronidazol");
            Corsinha("8");
            Console.WriteLine("Xarelto");
            Corsinha("9");
            Console.WriteLine("Saxenda");
            Corsinha("10");
            Console.WriteLine("Neosaldina");
            Corsinha("11");
            Console.WriteLine("Ibuprofeno");
            Corsinha("12");
            Console.WriteLine("Advil");
            Corsinha("13");
            Console.WriteLine("Ibupril");
            Corsinha("14");
            Console.WriteLine("Diclofenaco");
            Corsinha("15");
            Console.WriteLine("Omeprazol");
            Corsinha("16");
            Console.WriteLine("benegrip multi-noite");
            Corsinha("17");
            Console.WriteLine("benegrip multi-dia");
            Corsinha("18");
            Console.WriteLine("Glifage");
            Corsinha("19");
            Console.WriteLine("Torsilax");
            Corsinha("20");
            Console.WriteLine("Victoza ");
            Corsinha("21");
            Console.WriteLine("Anthelios");
            Corsinha("22");
            Console.WriteLine("Puran");
            Console.WriteLine("\n");
            Console.Write(" -");
            
            string indice = Console.ReadLine().ToLower();
            int remd = 0;
            if(indice.Length<3 && indice!=" ")
            {
                remd = Convert.ToInt32(indice);
            }
            
            Console.WriteLine("\n");
            
            Console.Clear();
            Console.Clear();
            Console.Clear();
            
            obj_entrar.Perfumariadois(txt_2);
            
            Console.Write("\n");
            
            
            if(remd==1)
            {
                Console.WriteLine(" o remedio consultado e "+remedio[remd]+" com o valor de "+preco_remed[remd]+"\n");
                Console.WriteLine(" Adultos e crianças acima de 12 anos 35 a 55 ");
                Console.WriteLine(" gotas, 3 a 5 vezes ao dia. A dose diária  ");
                Console.WriteLine(" máxima de paracetamolé de 4000 mg (275 gotas)\n administrados em doses fracionadas,\n não excedendo a dose de 1000 mg/dose (55 gotas)");
                Console.Write(" com intervalos de 4 a 6 horas, no período\n de 24 horas.");
               
            }
            else if(remd==2)
            {
                Console.WriteLine(" o remedio consultado e "+remedio[remd]+" com o valor de "+preco_remed[remd]+"\n");
                Console.WriteLine(" O que é a dipirona e para que serve");
                Console.WriteLine(" A dipirona é um anti-inflamatório não-esteroidal com ação analgésica e antitérmica.");
                Console.WriteLine(" Ela é indicada para agir contra febre, dor de cabeça, dor muscular e cólicas.");
                Console.WriteLine(" Essa droga integra o grupo dos medicamentos isentos de prescrição (MIPs).");
                Console.WriteLine(" Por isso, dá para comprá-la nas farmácias sem uma receita médica. Mesmo assim, é importante ter alguns cuidados");
            }
            else if(remd==3)
            {
                Console.WriteLine(" o remedio consultado e "+remedio[remd]+" com o valor de "+preco_remed[remd]+"\n");
                Console.WriteLine(" Tylenol:  Geralmente, a dose dose recomendada de Tylenol infantil varia de 10 a 15 mg/kg/dose,");
                Console.WriteLine(" que podem ser administradas de 4 em 4 horas ou de 6 em 6 horas. Tylenol Gotas:");
                Console.WriteLine(" a dose recomendada é de 1 gota por cada Kg de peso da criança,");
                Console.WriteLine(" nunca excedendo a dose máxima de 35 gotas ou as 5 administrações totais por dia.");
               
               
            }
            else if(remd==4)
            {
                Console.WriteLine(" o remedio consultado e "+remedio[remd]+" com o valor de "+preco_remed[remd]+"\n");
                Console.WriteLine(" 1 comprimido até 4 vezes ao dia para adultos e crianças acima de 15 anos.");
                Console.WriteLine(" Dissolver o comprimido em meio copo de água e beber imediatamente após o término ");
                Console.WriteLine(" da dissolução. O tratamento pode ser interrompido a qualquer instante sem provocar \n danos ao paciente, inerentes à retirada da medicação");
               
            }
            else if(remd==5)
            {
                Console.WriteLine(" o remedio consultado e "+remedio[remd]+" com o valor de "+preco_remed[remd]+"\n");
                Console.WriteLine(" Os remédios com pirantel só devem ser utilizados com orientação \n do médico, no entanto, as indicações gerais são:");
                Console.WriteLine("\n Xarope de 50 mg/ml\n");
                Console.WriteLine(" Crianças com menos de 12 Kg: ½ colher medida em dose única");
                Console.WriteLine(" Crianças com 12 a 22 Kg: ½ a 1 colher medida em dose única");
                Console.WriteLine(" Crianças com 23 a 41 Kg: 1 a 2 colheres medida em dose única");
                Console.WriteLine(" Crianças com 42 a 75 Kg: 2 a 3 colheres medida em dose única;");
                Console.WriteLine(" Adultos com mais de 75 Kg: 4 colheres medida em dose única.");
            }
            else if(remd==6)
            {
                Console.WriteLine(" o remedio consultado e "+remedio[remd]+" com o valor de "+preco_remed[remd]+"\n");
                Console.WriteLine(" dosagem: \n");
                Console.WriteLine(" Peso corporal (kg)\tDose oral única");
                Console.WriteLine(" 15 a 24 \t        1/2 comprimido");
                Console.WriteLine(" 25 a 35 \t        1 comprimido");
                Console.WriteLine(" 36 a 50 \t        1 1/2 comprimidos");
                Console.WriteLine(" 51 a 65 \t        2 comprimidos");
                Console.WriteLine(" 66 a 79 \t        2 1/2 comprimidos");
                Console.WriteLine("");
            }
            else if(remd==7)
            {
                Console.WriteLine(" o remedio consultado e "+remedio[remd]+" com o valor de "+preco_remed[remd]+"\n");
                Console.WriteLine(" Os comprimidos devem ser deglutidos inteiros, sem mastigar, \n com quantidade suficiente de líquido (aproximadamente 1 copo de agua).");
                Console.WriteLine(" 400 mg (1 comprimido de Metronidazol comprimidos 400 mg três vezes\n ao dia, durante 7 dias ou à critério médico). Tomar após as refeições.");
                Console.WriteLine(" Para crianças, Metronidazol deve ser usado preferencialmente na forma de suspensão\n - Metronidazol Pediátrico (benzoilmetronidazol).");
            }
            else if(remd==8)
            {
                Console.WriteLine(" o remedio consultado e "+remedio[remd]+" com o valor de "+preco_remed[remd]+"\n");
                Console.WriteLine(" Xarelto (rivaroxabana) é indicado para prevençao de derrame (AVC) e de formação de\n coágulo em outros vasos sanguíneos (embolia sistêmica) em pacientes adultos\n com arritmia do coraçao (fibrilação atrial não-valvular) ");
                Console.WriteLine(" a dosegem sera descrita de acordo com a necessidade observada pelo medico responsavel");
            }
            else if(remd==9)
            {
                Console.WriteLine(" o remedio consultado e "+remedio[remd]+" com o valor de "+preco_remed[remd]+"\n");
                Console.WriteLine(" Quando começar a utilizar Saxenda, a dose inicial\n é de 0,6 mg uma vez ao dia, por pelo menos uma semana\n Você poderá aumentar a dose em 0,6 mg a cada semana\n até atingir a dose recomendada de 3,0 mg uma vez ao dia.");
               
            }
            else if(remd==10)
            {
                Console.WriteLine(" o remedio consultado e "+remedio[remd]+" com o valor de "+preco_remed[remd]+"\n");
                Console.WriteLine(" Neosaldina é de uso exclusivo pela via oral (por boca).\n 1 a 2 drágeas (em dose única) a cada 6 horas ou 4 vezes ao dia.\n Não tome mais de 8 drágeas ao dia (4 x 2 drágeas).\n Este medicamento não deve ser partido, aberto ou mastigado.");
            }
            else if(remd==11)
            {
                Console.WriteLine(" o remedio consultado e "+remedio[remd]+" com o valor de "+preco_remed[remd]+"\n");
                Console.WriteLine(" Em adultos, a dose habitual do ibuprofeno é de 20 gotas (200 mg) a 80 gotas (800 mg)\n podendo ser re-petida por, no máximo, 4 vezes por dia.\n A dose máxima permitida por dia em adultos é de 320 gotas (3200 mg).\n Dose recomendada por, no máximo, 4 vezes ao dia.");
               
            }
            else if(remd==12)
            {
                Console.WriteLine(" o remedio consultado e "+remedio[remd]+" com o valor de "+preco_remed[remd]+"\n");
                Console.WriteLine(" Advil deve ser administrado por via oral na dose recomendada de 1 cápsula.\n Se necessário, essa dose pode ser repetida, com intervalo mínimo de 4-6 horas.\n Não exceder o total de 3 cápsulas (1.200 mg) em um período de 24 horas.\n Pode ser administrado junto com alimentos.");
               
            }
            else if(remd==13)
            {
                Console.WriteLine(" o remedio consultado e "+remedio[remd]+" com o valor de "+preco_remed[remd]+"\n");
                Console.WriteLine(" A dose recomendada é de 600mg 3 ou 4 vezes ao dia.\n A dose de Ibupril deve ser adequada a cada caso clínico, e pode ser\n diminuída ou aumentada a partir da dose inicial sugerida,\n dependendo da gravidade dos sintomas.");
              
            }
            else if(remd==14)
            {
                Console.WriteLine(" o remedio consultado e "+remedio[remd]+" com o valor de "+preco_remed[remd]+"\n");
                Console.WriteLine(" Adultos: a dose inicial diária é de 100 mg, ou seja,\n 1 comprimido ao dia. Se necessário, a dose diária pode ser aumentada a\n 150 mg com diclofenaco sódico comprimidos convencionais ou supositórios.");
               
            }
            else if(remd==15)
            {
                Console.WriteLine(" o remedio consultado e "+remedio[remd]+" com o valor de "+preco_remed[remd]+"\n");
                Console.WriteLine(" A dose oral para adultos é de 20 mg, administrada uma vez\n ao dia antes do café da manhã, durante 2 a 4 semanas no\n caso de úlceras duodenais e durante 4 a 8 semanas para\n úlceras gástricas e esofagite de refluxo. Na profilaxia\n de úlceras duodenais e esofagite de refluxo recomenda-se 10 ou 20\n mg antes do café da manhã.");
               
            }
            else if(remd==16)
            {
                Console.WriteLine(" o remedio consultado e "+remedio[remd]+" com o valor de "+preco_remed[remd]+"\n");
                Console.WriteLine(" Adultos e crianças acima de 12 anos: tomar 2 comprimidos (1 amarelo + 1 laranja)\n a cada 8 horas, com um copo de água. Quando usar Benegrip® Multi Dia e Benegrip\n Multi Noite, nunca tomar ao mesmo tempo e sempre respeitar\n o intervalo mínimo de 8 horas entre as doses.");
               
            }
            else if(remd==17)
            {
                Console.WriteLine(" o remedio consultado e "+remedio[remd]+" com o valor de "+preco_remed[remd]+"\n");
                Console.WriteLine(" Adultos e crianças acima de 12 anos: tomar 2 comprimidos (1 amarelo + 1 laranja)\n a cada 8 horas, com um copo de água. Quando usar Benegrip® Multi Dia e Benegrip\n Multi Noite, nunca tomar ao mesmo tempo e sempre respeitar\n o intervalo mínimo de 8 horas entre as doses.");
               
            }
            else if(remd==18)
            {
                Console.WriteLine(" o remedio consultado e "+remedio[remd]+" com o valor de "+preco_remed[remd]+"\n");
                Console.WriteLine(" A posologia é de, usualmente, 1000 a 1500 mg por dia (2 ou 3 comprimidos de Glifage® XR 500 mg)\n em uma única tomada. Aconselha-se iniciar o tratamento com dose baixa (1 comprimido de 500 mg/dia)\n e aumentar gradualmente a dose (1 comprimido de 500 mg a cada semana)\n até atingir a posologia desejada.");
               
            }
            else if(remd==19)
            {
                Console.WriteLine(" o remedio consultado e "+remedio[remd]+" com o valor de "+preco_remed[remd]+"\n");
                Console.WriteLine(" Como regra geral, a dose mínima diária recomendada é de um comprimido a cada 12 horas\n respeitando-se o máximo de um comprimido tomado a cada 8 horas, portanto, três doses diárias.");
               
            }
            else if(remd==20)
            {
                Console.WriteLine(" o remedio consultado e "+remedio[remd]+" com o valor de "+preco_remed[remd]+"\n");
                Console.WriteLine(" Adultos. A dose inicial é de 0,6 mg uma vez ao dia por pelo menos uma semana\n Seu médico lhe dirá quando aumentar a dose para 1,2 mg uma vez ao dia\n Seu médico pode lhe pedir que aumente a dose para 1,8 mg uma vez ao dia\n se sua glicemia não estiver controlada com uma dose de 1,2 mg.");
               
            }
            else if(remd==21)
            {
                Console.WriteLine(" o remedio consultado e "+remedio[remd]+" com o valor de "+preco_remed[remd]+"\n");
                Console.WriteLine(" Pressione levemente adicionando de 2 a 4 gotas. Com 2 gotas para uma cobertura leve \n Com 3 gotas para uma cobertura média | Com 4 gotas para uma cobertura alta.");
               
            }
            else if(remd==22)
            {
                Console.WriteLine(" o remedio consultado e "+remedio[remd]+" com o valor de "+preco_remed[remd]+"\n");
                Console.WriteLine(" recomenda-se 75 a 125 mcg diários sendo que alguns pacientes, com má absorção\n podem necessitar de até 200 mcg/dia. A maioria dos pacientes não exige doses\n superiores a 150 mcg/dia. A falta de resposta às doses de 200 mcg/dia sugere má absorção,\n não obediência ao tratamento ou erro diagnóstico");
               
            }
            else 
            {
                Console.Write("Por favor indique um indice existente!!\n"); 
            }
            
            Console.WriteLine("\n\n");
            
            Console.Write(" deseja consultar outra bula ");
            
            Corsinha("sim");
            Console.Write(" ou ");
            Corsinha("nao");
            Console.Write("? ");
            
            Console.Write(" -");
            resp = Console.ReadLine().ToLower();
            Console.Clear();
            
            
        }while(resp!="nao");
        
        
        Console.Clear();
        obj_entrar.Perfumariadois(txt_1);
        Console.Write("\n deseja adquirir algum destes remedios");
         Corsinha("sim");
        Console.Write(" ou ");
        Corsinha("nao");
        Console.Write("? ");
        string escolha_comp=Console.ReadLine().ToLower();
        if(escolha_comp=="sim")
        {
            Compra_de_remedio(cpf);
        }
        
    }
    public void Corsinha(string nun)
    {
        Console.Write(" [");
        Console.ForegroundColor = ConsoleColor.Red;    
        Console.Write(nun);
        Console.ForegroundColor = ConsoleColor.Black;  
        Console.Write("]");
    }
    public void Sobre()
    {
        Console.WriteLine();
        Corsinha("Desenvolvedores");
        Console.WriteLine("\n Cauê C. Zacharias");
        Console.WriteLine(" Kauan G. Apolinario");
        Console.WriteLine(" Yago Bastos\n");
        
        Corsinha("Contato");
        Console.WriteLine("\n Drog.SoRemedio@gmail.com\n");
        
        Corsinha("Versão");
        Console.WriteLine("\n 1.0.0 (Alpha)\n");
        
        Console.WriteLine(" De enter para voltar.");
        Console.ReadLine();
    }
}