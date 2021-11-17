/******************************************************************************

Utilizando o programa exemplo da apostila (Herança – página 46), modifique o programa conforme pede abaixo: 

- Coloque um título para o programa (pode utilizar recursos de cor se quiser); 

- Implemente uma nova classe Professor 

- No programa principal, deverá ser informado inicialmente se o cadastro a ser realizado é de aluno ou professor e ler os campos pertinentes as classes conforme a opção escolhida. 

- No final exibir a confirmação de cadastro informando qual o tipo de cadastro foi realizado (aluno ou professor)

- Incluir um método para a classe Pessoa onde deverá exibir a informação
“Cadastro realizado com sucesso!” 

- Utilizando polimorfismo, incluir um método na classe Aluno que vai exibir a informação
“Novo aluno matriculado.” 

- Utilizando polimorfismo, incluir um método na classe Professor que vai exibir a informação
“Novo professor admitido na escola.”

*******************************************************************************/
using System;
class Pessoa
{
    public string nome;
    public int data_nasc;
    public long cpf;
    
    public virtual void Txt_Confirm()
    {
        Console.WriteLine("\nCadastro realizado com sucesso!\n");
        
    }
    
    public void Idade(int idade)
    {
        string anos = Convert.ToString(20210809 - idade).Substring(0,2);
        Console.WriteLine("\n       ● Idade atual: "+anos);
    }
}


class Aluno : Pessoa 
{
    public int num_RA;
    public string nome_curso;
    
    public override void Txt_Confirm()
    {
        Console.WriteLine("\n      Novo aluno matriculado!");
    }
}

class Professor : Pessoa 
{
    public override void Txt_Confirm()
    {
        Console.WriteLine("\n      Novo professor admitido na escola!");
    }
    
    public string formacao;
    public int num_matricula;
}

class Ex_Herança
{
    
    
    static void Perfumaria()
    {
    
        Console.ForegroundColor = ConsoleColor.DarkMagenta;   
        Console.WriteLine("§============================================§");
        Console.ResetColor();
    }
    
  static void Main() 
  {
    
    Aluno aluno_cads = new Aluno();
    
    
    Perfumaria();
    
    Console.WriteLine("\n Bem vindo(a) ao sistema de cadastros da ESSJ!\n");
    string txt_sn;
    
    do
    {
        Console.Write("\n\n Deseja iniciar um cadastro? \n\n ● (\"[SIM]\"/\"[NAO]\"):");
        txt_sn = Console.ReadLine().ToUpper();
    
    
        if(txt_sn=="NAO")
        {
            Console.Clear();
            Perfumaria();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n             Fim da execuçao!!\n");
            Console.ResetColor();
            Perfumaria();
        }
    
        else if(txt_sn!="NAO")
        {
            Console.Clear();
            Console.Write("\n Digite A se for aluno ou P se for um professor: ");
        }
    
        string txt_1 = Console.ReadLine().ToLower();
    
        Professor prof_cads = new Professor();
    
        Console.Clear();
    
        if (txt_1=="a")
        {
            Perfumaria();
            Console.WriteLine("\n           Bem vindo(a) caro aluno!");
            Console.WriteLine("\n           Preencha os dados abaixo\n");
            Perfumaria();
        
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\n       ● Nome: ");
            aluno_cads.nome = Console.ReadLine().ToLower();
        
            Console.Write("\n       ● Data de nascimento (AAAAMMDD):");
            aluno_cads.data_nasc = Convert.ToInt32 (Console.ReadLine());
        
            aluno_cads.Idade(aluno_cads.data_nasc);
        
            Console.Write("\n       ● CPF: ");
            aluno_cads.cpf = Convert.ToInt64 (Console.ReadLine());
        
            Console.Write("\n       ● RA: ");
            aluno_cads.num_RA = Convert.ToInt32 (Console.ReadLine());
        
            Console.Write("\n       ● Curso: ");
            aluno_cads.nome_curso = Console.ReadLine();
        
            Console.WriteLine("\n");
        
            Perfumaria();
            Console.ForegroundColor = ConsoleColor.Blue;
            aluno_cads.Txt_Confirm();
            Console.WriteLine("\n      A ESSJ agradece "+aluno_cads.nome+"!\n");
            Console.ResetColor();
            Perfumaria();
        }
    
        else if(txt_1=="p")
        {
            Perfumaria();
            Console.WriteLine("\n           Bem vindo(a) caro professor!!");
            Console.WriteLine("\n           Preencha os dados abaixo\n");
            Perfumaria();
        
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("\n       ● Nome: ");
            prof_cads.nome = Console.ReadLine().ToLower();
        
            Console.Write("\n       ● Data de nascimento (AAAAMMDD):");
            prof_cads.data_nasc = Convert.ToInt32 (Console.ReadLine());
        
            prof_cads.Idade(prof_cads.data_nasc);
        
            Console.Write("\n       ● CPF: ");
            prof_cads.cpf = Convert.ToInt64 (Console.ReadLine());
        
            Console.Write("\n       ● Formação: ");
            prof_cads.formacao = Console.ReadLine();
        
            Console.Write("\n       ● Numero da matricula: ");
            prof_cads.num_matricula = Convert.ToInt32 (Console.ReadLine());
        
            Console.WriteLine("\n");
        
            Perfumaria();
            Console.ForegroundColor = ConsoleColor.Blue;
            prof_cads.Txt_Confirm();
            Console.WriteLine("\n      A ESSJ agradece "+prof_cads.nome+"!\n");
            Console.ResetColor();
            Perfumaria();
        }
    }while(txt_sn!="NAO");
  }
}


