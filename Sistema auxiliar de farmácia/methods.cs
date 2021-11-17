//metodos usados ao longo do programa
using System;
using System.IO;
class methods
{
    login obj_entrar = new login();
    public string txt = "\t Medicine recommendation";
    public string txt_1 = "\t\t Buy medicine ";
    public string txt_2 = "\t\t consult package insert ";
    
    enum bula
    {
        headaches,
        throat,
        earaches,
        muscle,
        stomach,
        toothaches
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
        Console.WriteLine(" Which of the symptoms below are you feeling: ");
        Corsinha("1");
        Console.Write(" Pains in the head region\n");
        Corsinha("2");
        Console.Write(" Sore throat\n");
        Corsinha("3");
        Console.Write(" Earaches\n");
        Corsinha("4");
        Console.Write(" Muscle aches\n");
        Corsinha("5");
        Console.Write(" Stomachaches\n");
        Corsinha("6");
        Console.Write(" Toothaches\n");
        Console.Write(" -");
        string escolha = Console.ReadLine();
        if(escolha=="1")
        {
            Console.Clear();
            obj_entrar.Perfumariadois(txt);
            bula meu_remedio = bula.headaches;
            Console.WriteLine(" The most recommended remedies for "+meu_remedio+" are: \n");
            Console.Write(" | ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Analgesics");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" | ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Anti-inflammatory");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" |\n");
            Console.WriteLine(" | acetaminophen |     Ibuprofen     |");
            Console.WriteLine(" |   dipyrone    |      Advil        |");
            Console.WriteLine(" |   Tylenol     |     Ibupril       |");
            Console.WriteLine(" |   Novalgin    |    diclofenac     |");
            escolha="yes";
        }
        else if(escolha=="2")
        {
            Console.Clear();
            obj_entrar.Perfumariadois(txt);
            bula meu_remedio = bula.throat;
            Console.WriteLine(" The most recommended remedies for "+meu_remedio+" are: \n");
            Console.Write(" | ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Analgesics");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" | ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Anti-inflammatory");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" |\n");
    
            Console.WriteLine(" | acetaminophen |     Ibuprofen     |");
            Console.WriteLine(" |   dipyrone    |      Advil        |");
            Console.WriteLine(" |   Tylenol     |     Ibupril       |");
            Console.WriteLine(" |   Novalgin    |    diclofenac     |");
            escolha="yes";
        }
        else if(escolha=="3")
        {
            Console.Clear();
            obj_entrar.Perfumariadois(txt);
            bula meu_remedio = bula.earaches;
            Console.WriteLine(" The most recommended remedies for "+meu_remedio+" are: \n");
            Console.Write(" | ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Analgesics");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" | ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Anti-inflammatory");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" |\n");
    
            Console.WriteLine(" | acetaminophen |     Ibuprofen     |");
            Console.WriteLine(" |   dipyrone    |      Advil        |");
            Console.WriteLine(" |   Tylenol     |     Ibupril       |");
            Console.WriteLine(" |   Novalgin    |    diclofenac     |");
            escolha="yes";
        }
        else if(escolha=="4")
        {
            Console.Clear();
            obj_entrar.Perfumariadois(txt);
            bula meu_remedio = bula.muscle;
            Console.WriteLine(" The most recommended remedies for "+meu_remedio+" pain are: \n");
            Console.Write(" | ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Analgesics");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" | ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Anti-inflammatory");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" |\n");
    
            Console.WriteLine(" | acetaminophen |     Ibuprofen     |");
            Console.WriteLine(" |   dipyrone    |      Advil        |");
            Console.WriteLine(" |   Tylenol     |     Ibupril       |");
            Console.WriteLine(" |   Novalgin    |    diclofenac     |");
            escolha="yes";
        }
        else if(escolha=="5")
        {
            Console.Clear();
            obj_entrar.Perfumariadois(txt);
            bula meu_remedio = bula.stomach;
            Console.Write(" The most recommended remedies for "+meu_remedio+" pain are: \n");
            Console.WriteLine("\n\n");
            Console.Write(" | ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("      Antacids     ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("  | ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("   Inhibitors of  ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("  |\n");
            Console.Write(" | ");
            Console.Write("                     ");
            Console.Write("| ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("  acid production");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("   |\n");
            Console.WriteLine(" | aluminum hydroxide   |      Pepsamar       |");
            Console.WriteLine(" | magnesium hydroxide  |       Maalox        |");
            Console.WriteLine(" |     Estomazil        |     esomeprazole    |");
            escolha="yes";
        }
        else if(escolha=="6")
        {
            Console.Clear();
            obj_entrar.Perfumariadois(txt);
            bula meu_remedio = bula.toothaches;
            Console.WriteLine(" The most recommended remedies for "+meu_remedio+" are: \n");
            Console.Write(" | ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Analgesics");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" | ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Anti-inflammatory");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" |\n");
    
            Console.WriteLine(" | Paracetamol |     Ibuprofeno     |");
            Console.WriteLine(" |   dipirona  |      Advil         |");
            Console.WriteLine(" |   Tylenol   |     Ibupril        |");
            Console.WriteLine(" |  Novalgina  |    diclofenaco     |");
            escolha="yes";
        }
        if(escolha=="yes")
            {
            Console.Write("\n Do you want to purchase any of these remedies");
            Corsinha("yes");
            Console.Write(" or ");
            Corsinha("no");
            Console.Write("? ");
            string escolha_comp=Console.ReadLine().ToLower();
                if(escolha_comp=="yes")
                {
                    Compra_de_remedio(cpf);
                }
            }
            else
            {
            Console.Write("\n Press enter to go back.");
            Console.ReadLine();
            }
    }
    public void Imc()
    {
        Console.Write(" Enter your weight: ");
        double peso_use = Convert.ToDouble(Console.ReadLine());
        Console.Write(" Enter your height in Meters: ");
        double altura_user = Convert.ToDouble(Console.ReadLine());
        double imc_user = peso_use/(altura_user*altura_user);
        double imc=Math.Round(imc_user);
        
        if(imc<=17)
        {
            Console.WriteLine(" Your BMI is:"+imc+" you are severely thin");
            Console.WriteLine(" This can cause: ");
            Console.WriteLine(" Cardiac insufficiency");
            Console.WriteLine(" severe anemia");
            Console.WriteLine(" Weakening of the immune system");
        }
        else if(imc>17 & imc<=18.5)
        {
            Console.WriteLine(" Your BMI is:"+imc+" you have a slight thinness");
            Console.WriteLine(" This can cause: ");
            Console.WriteLine("Health problems linked to malnutrition");
        }
        else if(imc>18.5 & imc<=24.9)
        {
            Console.WriteLine(" Your BMI is:"+imc+" you are eutrophic");
            Console.WriteLine(" Healthy");
        }
        else if(imc>25 & imc<=29.9)
        {
            Console.WriteLine(" Your BMI is:"+imc+" you are overweight");
            Console.WriteLine(" This can cause: ");
            Console.WriteLine(" Fatigue");
            Console.WriteLine(" varicose veins");
            Console.WriteLine(" bad circulation");
        }
        else if(imc>30 & imc<=34.9)
        {
            Console.WriteLine(" Your BMI is:"+imc+" you are obese type I");
            Console.WriteLine(" This can cause: ");
            Console.WriteLine(" Diabetes");
            Console.WriteLine(" infarction");
            Console.WriteLine(" Angina");
            Console.WriteLine(" atherosclerosis");
        }
        else if(imc>35 & imc<=39.9)
        {
            Console.WriteLine(" Your BMI is:"+imc+" you are obese type II");
            Console.WriteLine(" This can cause: ");
            Console.WriteLine(" Shortness of breathe");
            Console.WriteLine(" Sleep apnea");
        }
        else if(imc>40)
        {
            Console.WriteLine(" Your BMI is:"+imc+" you are obese type III");
            Console.WriteLine(" This can cause: ");
            Console.WriteLine(" Reflux");
            Console.WriteLine(" infarction");
            Console.WriteLine(" Avc");
            Console.WriteLine(" Difficulty in walking");
        }
        Console.Write("\n Press enter to go back.");
        Console.ReadLine();
    }
    
    public void AgendamentoDeConsulta()
    {
       Console.WriteLine(" Choose the health center closest to your home: "); 
       Corsinha("1");
       Console.WriteLine("Health Center - Airport");
       Corsinha("2");
       Console.WriteLine("Health Center - Oziel unity");
       Corsinha("3");
       Console.WriteLine("Health Center - \"Santos Dumont\"");
       Corsinha("4");
       Console.WriteLine("Health Center - Center Campinas Unity");
       Corsinha("5");
       Console.WriteLine("Health Center - Carvalho de Moura");
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
           string txt = "\t       Schedule an appointment";
           obj_entrar.Perfumariadois(txt);
           Console.WriteLine(" Non-existent choice!");
       }
       Console.WriteLine(" Press enter to go back.");
       Console.ReadLine();
    }
    public void dia_consulta()
    {
        Console.WriteLine(" What's the best day to schedule?");
        Console.Write(" Enter the date in the format (dd/mm/yyyy): ");
        string data_consulta = Console.ReadLine();
        Console.Clear();
        string txt = "\t       Scheduled consultation";
        obj_entrar.Perfumariadois(txt);
        Console.WriteLine(" Your appointment has been scheduled for the day: "+data_consulta);
        Console.WriteLine(" With the Doctor Garibaldo");
    }
    public void AgendamentoDevacina()
    {
       Console.WriteLine(" Choose the health center closest to your home: "); 
       Corsinha("1");
       Console.WriteLine("Health Center - Airport");
       Corsinha("2");
       Console.WriteLine("Health Center - Oziel unity");
       Corsinha("3");
       Console.WriteLine("Health Center - \"Santos Dumont\"");
       Corsinha("4");
       Console.WriteLine("Health Center - Center Campinas Unity");
       Corsinha("5");
       Console.WriteLine("Health Center - Carvalho de Moura");
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
           string txt = "\t       schedule vaccine";
           obj_entrar.Perfumariadois(txt);
           Console.WriteLine(" Non-existent choice!");
       }
       Console.WriteLine(" Press enter to go back.");
       Console.ReadLine();
    }
    
    
    public void dia_Vacina()
    {
        Console.WriteLine(" What is the best day for scheduling?");
        Console.Write(" Enter the date in dd/mm format: ");
        string data_vacina = Console.ReadLine();
        Console.Clear();
        string txt = "\t       scheduled vaccine";
        obj_entrar.Perfumariadois(txt);
        Console.WriteLine(" Your appointment has been scheduled for the day: "+data_vacina);
        Console.WriteLine(" With Nurse Claudia");
    }
     public void Criar_cartao()
    {
        string condicao_de_parada="ap";
        string arquivo_cartoes = @"Cartao_User.txt";
        string existe_cartao ="nao";
        Console.WriteLine("\n to earn 20% discount enter the CPF n that was used to perform the registration");
        Console.Write(" CPF : ");
        string cpf_user_cartao = Console.ReadLine();
        do
        {
            if(!File.Exists(arquivo_cartoes))
            {
                string texto = "CPF of users who have the card;\n";
                File.WriteAllText(arquivo_cartoes,texto);
            }
            else{
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
                        Console.WriteLine("\n CPF already registered.\n");
                        Console.Write(" Press enter to go back.");
                        Console.ReadLine();
                    }
                }
            }
        }while(condicao_de_parada=="ap");
        if(existe_cartao!="sim")
        {
            Console.Clear();
            string txt = "\t       Card created";
            obj_entrar.Perfumariadois(txt);
            Console.WriteLine("\n Terminate the application for the bonus to be applied!!\n");
            Console.Write(" Press enter to go back");
            string dados_user_cartao = string.Concat(cpf_user_cartao,";\n");
            File.AppendAllText(arquivo_cartoes,dados_user_cartao);
            Console.ReadLine();
        }
    }
    public void Compra_de_remedio(string cpf)
    {
        string[] remedio ={" ","acetaminophen","dipyrone","Tylenol","Novalgin","pyrantel(ascarical)","Ivermectin","Metronidazole","Xarelto","Saxenda","Neosaldin","Ibuprofen","Advil","Ibupril","diclofenac","Omeprazole","benegrip_multi_night","benegrip_multi_day","Glifage","Torsilax","Victoza","Anthelios","Puran"};
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
            Console.WriteLine(" select according to the index\n the medicine you want to buy:");
            Console.WriteLine("\n");
            
            Console.WriteLine(" Remedies...............from \n");
            
            Corsinha("1");
            Console.WriteLine("acetaminophen............R$ "+preco_remed[1]);
            Corsinha("2");
            Console.WriteLine("dipyrone.................R$ "+preco_remed[2]);
            Corsinha("3");
            Console.WriteLine("Tylenol..................R$ "+preco_remed[3]);
            Corsinha("4");
            Console.WriteLine("Novalgin.................R$ "+preco_remed[4]);
            Corsinha("5");
            Console.WriteLine("pyrantel(ascarical)......R$ "+preco_remed[5]);
            Corsinha("6");
            Console.WriteLine("Ivermectin...............R$ "+preco_remed[6]);
            Corsinha("7");
            Console.WriteLine("Metronidazole............R$ "+preco_remed[7]);
            Corsinha("8");
            Console.WriteLine("Xarelto..................R$ "+preco_remed[8]);
            Corsinha("9");
            Console.WriteLine("Saxenda..................R$ "+preco_remed[9]);
            Corsinha("10");
            Console.WriteLine("Neosaldin...............R$ "+preco_remed[10]);
            Corsinha("11");
            Console.WriteLine("Ibuprofen...............R$ "+preco_remed[11]);
            Corsinha("12");
            Console.WriteLine("Advil...................R$ "+preco_remed[12]);
            Corsinha("13");
            Console.WriteLine("Ibupril.................R$ "+preco_remed[13]);
            Corsinha("14");
            Console.WriteLine("diclofenac..............R$ "+preco_remed[14]);
            Corsinha("15");
            Console.WriteLine("omeprazole..............R$ "+preco_remed[15]);
            Corsinha("16");
            Console.WriteLine("benegrip_multi_night....R$ "+preco_remed[16]);
            Corsinha("17");
            Console.WriteLine("benegrip_multi_day......R$ "+preco_remed[17]);
            Corsinha("18");
            Console.WriteLine("Glyphage................R$ "+preco_remed[18]);
            Corsinha("19");
            Console.WriteLine("Torsilax................R$ "+preco_remed[19]);
            Corsinha("20");
            Console.WriteLine("Victoza.................R$ "+preco_remed[20]);
            Corsinha("21");
            Console.WriteLine("Anthelios...............R$ "+preco_remed[21]);
            Corsinha("22");
            Console.WriteLine("Puran...................R$ "+preco_remed[22]);
            Console.WriteLine("\n");
            Console.Write(" which medicine will you add to the cart? ");
            
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
               
               Console.WriteLine(" you added "+remedio[remd]+" to your cart that costs "+preco_remed[remd]);
               total=total+preco_remed[remd];
               conca = string.Concat(conca," ",remedio[remd],"..............",preco_remed[remd],"\n");
               
               
            }
            else if(remd==2)
            {
                Console.Write("\n");
                Console.WriteLine(" you added "+remedio[remd]+" to your cart that costs "+preco_remed[remd]);
                total=total+preco_remed[remd];
                conca = string.Concat(conca," ",remedio[remd],".................",preco_remed[remd],"\n");
                
            }
            else if(remd==3)
            {
                Console.WriteLine(" you added "+remedio[remd]+" to your cart that costs "+preco_remed[remd]);
                total=total+preco_remed[remd];
                conca = string.Concat(conca," ",remedio[remd],"..................",preco_remed[remd],"\n");
                
            }
            else if(remd==4)
            {
                Console.WriteLine(" you added "+remedio[remd]+" to your cart that costs "+preco_remed[remd]);
                total=total+preco_remed[remd];
                conca = string.Concat(conca," ",remedio[remd],"................",preco_remed[remd],"\n");
                
                
            }
            else if(remd==5)
            {
                Console.WriteLine(" you added "+remedio[remd]+" to your cart that costs "+preco_remed[remd]);
                total=total+preco_remed[remd];
                conca = string.Concat(conca," ",remedio[remd],"......",preco_remed[remd],"\n");
                
            }
            else if(remd==6)
            {
                Console.WriteLine(" you added "+remedio[remd]+" to your cart that costs "+preco_remed[remd]);
                total=total+preco_remed[remd];
                conca = string.Concat(conca," ",remedio[remd],"..............",preco_remed[remd],"\n");
                
            }
            else if(remd==7)
            {
                Console.WriteLine(" you added "+remedio[remd]+" to your cart that costs "+preco_remed[remd]);
                total=total+preco_remed[remd];
                conca = string.Concat(conca," ",remedio[remd],".............",preco_remed[remd],"\n");
            }
            else if(remd==8)
            {
                Console.WriteLine(" you added "+remedio[remd]+" to your cart that costs "+preco_remed[remd]);
                total=total+preco_remed[remd];
                conca = string.Concat(conca," ",remedio[remd],"..................",preco_remed[remd],"\n");
                
            }
            else if(remd==9)
            {
                Console.WriteLine(" you added "+remedio[remd]+" to your cart that costs "+preco_remed[remd]);
                total=total+preco_remed[remd];
                conca = string.Concat(conca," ",remedio[remd],"..................",preco_remed[remd],"\n");
                
            }
            else if(remd==10)
            {
                Console.WriteLine(" you added "+remedio[remd]+" to your cart that costs "+preco_remed[remd]);
                total=total+preco_remed[remd];
                conca = string.Concat(conca," ",remedio[remd],"..............",preco_remed[remd],"\n");
                
            }
            else if(remd==11)
            {
                Console.WriteLine(" you added "+remedio[remd]+" to your cart that costs "+preco_remed[remd]);
                total=total+preco_remed[remd];
                conca = string.Concat(conca," ",remedio[remd],"..............",preco_remed[remd],"\n");
                
            }
            else if(remd==12)
            {
                Console.WriteLine(" you added "+remedio[remd]+" to your cart that costs "+preco_remed[remd]);
                total=total+preco_remed[remd];
                conca = string.Concat(conca," ",remedio[remd],"...................",preco_remed[remd],"\n");
                
            }
            else if(remd==13)
            {
                Console.WriteLine(" you added "+remedio[remd]+" to your cart that costs "+preco_remed[remd]);
                total=total+preco_remed[remd];
                conca = string.Concat(conca," ",remedio[remd],".................",preco_remed[remd],"\n");
                
            }
            else if(remd==14)
            {
                Console.WriteLine(" you added "+remedio[remd]+" to your cart that costs "+preco_remed[remd]);
                total=total+preco_remed[remd];
                conca = string.Concat(conca," ",remedio[remd],".........",preco_remed[remd],"\n");
                
            }
            else if(remd==15)
            {
               Console.WriteLine(" you added "+remedio[remd]+" to your cart that costs "+preco_remed[remd]);
               total=total+preco_remed[remd];
               conca = string.Concat(conca," ",remedio[remd],"...............",preco_remed[remd],"\n");
               
            }
            else if(remd==16)
            {
               Console.WriteLine(" you added "+remedio[remd]+" to your cart that costs "+preco_remed[remd]);
               total=total+preco_remed[remd];
               conca = string.Concat(conca," ",remedio[remd],"....",preco_remed[remd],"\n");
              
            }
            else if(remd==17)
            {
               Console.WriteLine(" you added "+remedio[remd]+" to your cart that costs "+preco_remed[remd]);
               total=total+preco_remed[remd];
               conca = string.Concat(conca," ",remedio[remd],"......",preco_remed[remd],"\n");
              
            }
            else if(remd==18)
            {
               Console.WriteLine(" you added "+remedio[remd]+" to your cart that costs "+preco_remed[remd]);
               total=total+preco_remed[remd];
               conca = string.Concat(conca," ",remedio[remd],".................",preco_remed[remd],"\n");
                
            }
            else if(remd==19)
            {
               Console.WriteLine(" you added "+remedio[remd]+" to your cart that costs "+preco_remed[remd]);
               total=total+preco_remed[remd];
               conca = string.Concat(conca," ",remedio[remd],"................",preco_remed[remd],"\n");
               
            }
            else if(remd==20)
            {
                Console.WriteLine(" you added "+remedio[remd]+" to your cart that costs "+preco_remed[remd]);
                total=total+preco_remed[remd];
                conca = string.Concat(conca," ",remedio[remd],".................",preco_remed[remd],"\n");
                
            }
            else if(remd==21)
            {
                Console.WriteLine(" you added "+remedio[remd]+" to your cart that costs "+preco_remed[remd]);
                total=total+preco_remed[remd];
                conca = string.Concat(conca," ",remedio[remd],"...............",preco_remed[remd],"\n");
                
            }
            else if(remd==22)
            {
                Console.WriteLine(" you added "+remedio[remd]+" to your cart that costs "+preco_remed[remd]);
                total=total+preco_remed[remd];
                conca = string.Concat(conca," ",remedio[remd],"...................",preco_remed[remd],"\n");
                
            }
            else 
            {
                Console.Write(" Please indicate an existing index!!"); 
                Console.ReadLine();
            }
            
            Console.Write("\n\n");
            
            Console.Write(" want to buy another medicine ");
            Corsinha("yes");
            Console.Write(" or ");
            Corsinha("no");
            esco = Console.ReadLine().ToLower();
            
        }while(esco!="no");
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
            Console.Write(" the remedies in your cart are:\n");
            Console.Write("\n");
            Console.Write(conca);
            Console.Write("\n");
            double total_desc=total-(total*0.20);
            Console.Write(" the discount of");
            Console.Write(" 20%");
            Console.Write(" for having the card has already been applied\n\n");
            Console.WriteLine(" the total amount to pay for your purchase is: "+total_desc);
            Console.Write("\n");
            Console.Write(" Enter to return.");
            Console.ReadLine();  
        }
        else
        {
            obj_entrar.Perfumariadois(txt_1);
            Console.Write(" the remedies in your cart are:\n");
            Console.Write("\n");
            Console.Write(conca);
            Console.Write("\n");
            Console.WriteLine(" the total amount to pay for your purchase is: "+total);
            Console.Write("\n");
            Console.Write(" Press enter to go back.");
            Console.ReadLine();  
        }
    }
    public void Bula(string cpf)
    {
        string[] remedio ={" ","acetaminophen","dipyrone","Tylenol","Novalgin","pyrantel(ascarical)","Ivermectin","Metronidazole","Xarelto","Saxenda","Neosaldin","Ibuprofen","Advil","Ibupril","diclofenac","Omeprazole","benegrip_multi_night","benegrip_multi_day","Glifage","Torsilax","Victoza","Anthelios","Puran"};
        double[] preco_remed={0,3.95,2.05,6.19,6.93,9.98,16.84,9.49,103.81,713.98,2.25,5.01,2.79,3.31,3.49,3.70,8.48,8.74,20.95,1.49,22.91,45.01,3.01};
        string resp =" ";
        
        Console.Clear();
        
        do
        {
            
            obj_entrar.Perfumariadois(txt_2);
            Console.Write("\n");
            Console.WriteLine(" Select, according to the index\n the remedy you want to consult the package insert:");
            Console.Write("\n");
            
            Console.WriteLine(" Remedies...............from \n");
            
            Corsinha("1");
            Console.WriteLine("acetaminophen ");
            Corsinha("2");
            Console.WriteLine("dipyrone ");
            Corsinha("3");
            Console.WriteLine("Tylenol ");
            Corsinha("4");
            Console.WriteLine("Novalgin ");
            Corsinha("5");
            Console.WriteLine("pyrantel(ascarical) ");
            Corsinha("6");
            Console.WriteLine("Ivermectin ");
            Corsinha("7");
            Console.WriteLine("Metronidazole ");
            Corsinha("8");
            Console.WriteLine("Xarelto ");
            Corsinha("9");
            Console.WriteLine("Saxenda ");
            Corsinha("10");
            Console.WriteLine("Neosaldin ");
            Corsinha("11");
            Console.WriteLine("Ibuprofen ");
            Corsinha("12");
            Console.WriteLine("Advil ");
            Corsinha("13");
            Console.WriteLine("Ibupril ");
            Corsinha("14");
            Console.WriteLine("diclofenac ");
            Corsinha("15");
            Console.WriteLine("omeprazole ");
            Corsinha("16");
            Console.WriteLine("benegrip_multi_night ");
            Corsinha("17");
            Console.WriteLine("benegrip_multi_day ");
            Corsinha("18");
            Console.WriteLine("Glyphage ");
            Corsinha("19");;
            Console.WriteLine("Torsilax ");
            Corsinha("20");
            Console.WriteLine("Victoza ");
            Corsinha("21");
            Console.WriteLine("Anthelios ");
            Corsinha("22");
            Console.WriteLine("Puran ");
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
               Console.WriteLine(" Adults and children over 12 years old 35 to 55 ");
               Console.WriteLine(" drops, 3 to 5 times a day. the daily dose  ");
               Console.WriteLine(" maximum acetaminophen is 4000 mg (275 drops)\n administered in fractional doses,\n not exceeding the dose of 1000 mg/dose (55 drops)");
               Console.Write(" with intervals of 4 to 6 hours, in the period\n of 24 hours.");
               
            }
            else if(remd==2)
            {
                Console.WriteLine(" What is dipyrone and what is it for");
               Console.WriteLine(" Dipyrone is a non-steroidal anti-inflammatory with analgesic and antipyretic action.");
               Console.WriteLine(" It is indicated to act against fever, headache, muscle pain and cramps.");
               Console.WriteLine(" This drug is part of the group of over-the-counter medications.");
               Console.WriteLine(" Therefore, you can buy it from pharmacies without a prescription. Still, it's important to be careful");
            }
            else if(remd==3)
            {
                Console.WriteLine(" Tylenol: Generally, the recommended dose of infant Tylenol ranges from 10 to 15 mg/kg/dose,");
               Console.WriteLine(" which can be administered every 4 hours or every 6 hours. Tylenol Drops:");
               Console.WriteLine(" the recommended dose is 1 drop for each kg of the child's weight,");
               Console.WriteLine(" never exceeding the maximum dose of 35 drops or 5 total administrations per day.");
               
               
            }
            else if(remd==4)
            {
               Console.WriteLine(" 1 tablet up to 4 times a day for adults and children over 15 years old.");
               Console.WriteLine(" Dissolve the tablet in half a glass of water and drink it immediately after completion ");
               Console.WriteLine(" of dissolution. The treatment can be interrupted at any time without causing \n damage to the patient, inherent to the withdrawal of the medication");
               
            }
            else if(remd==5)
            {
               Console.WriteLine(" Medicines with pyrantel should only be used with \n the doctor's guidance, however, the general indications are:");
               Console.WriteLine("\n 50 mg/ml syrup\n");
               Console.WriteLine(" Children under 12 kg: ½ scoop in a single dose");
               Console.WriteLine(" Children weighing 12 to 22 kg: ½ to 1 scoop measured in a single dose");
               Console.WriteLine(" Children weighing 23 to 41 kg: 1 to 2 scoops measured in a single dose");
               Console.WriteLine(" Children weighing 42 to 75 kg: 2 to 3 scoops measured in a single dose");
               Console.WriteLine(" Adults over 75 kg: 4 scoops in a single dose.");
            }
            else if(remd==6)
            {
                Console.WriteLine(" dosage: \n");
                Console.WriteLine(" Body weight (kg)\tSingle oral dose");
               Console.WriteLine(" 15 to 24 \t        1/2 pill");
               Console.WriteLine(" 25 to 35 \t        1 pill");
               Console.WriteLine(" 36 to 50 \t        1 1/2 pills");
               Console.WriteLine(" 51 to 65 \t        2 pills");
               Console.WriteLine(" 66 to 79 \t        2 1/2 pills");
               Console.WriteLine("");
            }
            else if(remd==7)
            {
                Console.WriteLine(" The tablets should be swallowed whole, without chewing, \n with a sufficient amount of liquid (approximately 1 glass of water).");
               Console.WriteLine(" 400 mg (1 tablet of Metronidazole 400 mg tablets three times\n daily for 7 days or at the discretion of the physician). Take after meals.");
               Console.WriteLine(" For children, Metronidazole should preferably be used in suspension form\n - Pediatric Metronidazole (benzoylmetronidazole).");
            }
            else if(remd==8)
            {
                Console.WriteLine(" Xarelto (rivaroxaban) is indicated for the prevention of stroke (stroke) and clot formation in\n other blood vessels (systemic embolism) in adult patients\n with heart arrhythmia (non-valvular atrial fibrillation) ");
                Console.WriteLine(" the dosage will be described according to the need observed by the responsible physician");
            }
            else if(remd==9)
            {
               Console.WriteLine(" When you start using Saxenda, the starting dose\n is 0.6 mg once a day for at least a week\n You can increase the dose by 0.6 mg every week\n until you reach the recommended dose of 3.0 mg once a day.");
               
            }
            else if(remd==10)
            {
               Console.WriteLine("Neosaldina is for oral use only (by mouth).\n 1 to 2 tablets (in a single dose) every 6 hours or 4 times a day.\n Do not take more than 8 tablets a day (4 x 2 tablets) .\n This medicine must not be broken, opened or chewed.");
            }
            else if(remd==11)
            {
               Console.WriteLine(" For adults, the usual dose of ibuprofen is 20 drops (200 mg) to 80 drops (800 mg)\n it can be repeated up to 4 times a day.\n The maximum dose allowed per day in adults is 320 drops (3200 mg).\n Recommended dose for a maximum of 4 times a day.");
               
            }
            else if(remd==12)
            {
               Console.WriteLine(" Advil should be administered orally at the recommended dose of 1 capsule.\n If necessary, this dose may be repeated, with a minimum interval of 4-6 hours.\n Do not exceed a total of 3 capsules (1,200 mg) in a period 24 hours.\nCan be administered with food.");
               
            }
            else if(remd==13)
            {
               Console.WriteLine(" The recommended dose is 600mg 3 or 4 times a day.\nThe dose of Ibupril should be appropriate for each clinical case, and may be\ndecreased or increased from the suggested starting dose,\ndepending on the severity of symptoms.");
              
            }
            else if(remd==14)
            {
                Console.WriteLine(" Adults: the starting daily dose is 100 mg, ie\n 1 tablet daily. If necessary, the daily dose can be increased to\n 150 mg with diclofenac sodium conventional tablets or suppositories.");
               
            }
            else if(remd==15)
            {
              Console.WriteLine(" The oral dose for adults is 20 mg, given once\n a day before breakfast, for 2 to 4 weeks for\n duodenal ulcers and for 4 to 8 weeks for\n gastric ulcers and reflux esophagitis . For prophylaxis\n of duodenal ulcers and reflux esophagitis, 10 or 20\n mg before breakfast is recommended.");
               
            }
            else if(remd==16)
            {
              Console.WriteLine(" Adults and children over 12 years: take 2 tablets (1 yellow + 1 orange)\n every 8 hours with a glass of water. When using Benegrip® Multi Day and Benegrip\n Multi Night, never take at the same time and always\n respect the minimum interval of 8 hours between doses.");
               
            }
            else if(remd==17)
            {
            Console.WriteLine(" Adults and children over 12 years: take 2 tablets (1 yellow + 1 orange)\n every 8 hours with a glass of water. When using Benegrip® Multi Day and Benegrip\n Multi Night, never take at the same time and always\n respect the minimum interval of 8 hours between doses.");
               
            }
            else if(remd==18)
            {
              Console.WriteLine(" The dosage is usually 1000 to 1500 mg per day (2 or 3 Glifage® XR 500 mg tablets)\n in a single dose. It is advisable to start the treatment with a low dose (1 tablet of 500 mg/day)\n and gradually increase the dose (1 tablet of 500 mg every week)\n until reaching the desired dosage.");
               
            }
            else if(remd==19)
            {
              Console.WriteLine(" As a general rule, the minimum recommended daily dose is one tablet every 12 hours\n respecting the maximum of one tablet taken every 8 hours, therefore, three daily doses.");
               
            }
            else if(remd==20)
            {
                Console.WriteLine(" Adults: The starting dose is 0.6 mg once a day for at least one week\n Your doctor will tell you when to increase your dose to 1.2 mg once a day\n Your doctor may ask you to increase your dose to 1.8 mg once a day\n if your blood sugar is not controlled with a 1.2 mg dose.");
               
            }
            else if(remd==21)
            {
                Console.WriteLine(" Lightly press adding 2 to 4 drops. With 2 drops for light coverage \n With 3 drops for medium coverage | With 4 drops for high coverage.");
               
            }
            else if(remd==22)
            {
                Console.WriteLine(" It is recommended 75 to 125 mcg daily and some patients with malabsorption\n may need up to 200 mcg/day. Most patients do not require\n doses greater than 150 mcg/day. Lack of response to doses of 200 mcg/day suggests malabsorption,\n noncompliance with treatment or misdiagnosis.");
               
            }
            else 
            {
               Console.Write("Please indicate an existing index!!"); 
                
            }
            
            Console.WriteLine("\n\n");
            
            Console.Write("\n Do you want to consult other package insert? ");
            Corsinha("yes");
            Console.Write(" or ");
            Corsinha("no");
            Console.Write(" -");
            resp = Console.ReadLine().ToLower();
            Console.Clear();
            Console.Clear();
            
        }while(resp!="no");
        Console.Clear();
        obj_entrar.Perfumariadois(txt_1);
        Console.Write(" Do you want to purchase any of these remedies");
        Corsinha("yes");
        Console.Write(" or ");
        Corsinha("no");
        Console.Write("? ");
        string escolha_comp=Console.ReadLine().ToLower();
        if(escolha_comp=="yes")
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
    public void About()
    {
        Console.WriteLine();
        Corsinha("Developers");
        Console.WriteLine("\n Cauê C. Zacharias");
        Console.WriteLine(" Kauan G. Apolinario");
        Console.WriteLine(" Yago Bastos\n");
        
        Corsinha("Contact");
        Console.WriteLine("\n Drog.SoRemedio@gmail.com\n");
        
        Corsinha("Version");
        Console.WriteLine("\n 1.0.0 (Alpha)\n");
        
        Console.WriteLine(" Press enter to go back.");
        Console.ReadLine();
    }
}