/******************************************************************************
-Framacia
-entrada

-entrar{
    CPF
    senha / palavra chave
    
    agendar consulta
    {
        mostrar os dias possíveis e o usuario escolhe qual dia ele pode ir
    }
    comprar remedio
    {
        mostrar uma tabela com os remedios e preços/ primeira compra tem disconto 20%/ cartão 20%
    }
    agendar vascinação
    {
        mostrar os dias pociveis e o usuario escolhe qual dia ele pode ir/ mostrar quais vascinas disponiveis 
    }
    pesquisa sobre remedio
    {
        pesquisa nome do remedio: mostra a bula do remedio
    }
    recomendação de remedio 
    {
        escolhe quais os sintomas da pessoa e indica um remedio
    }
    consulta sobre peso
    {
        pergunta peso e altura da pessoa: mostra se está saldavel
    }
    criar cartão da farmacia
    {
        mostra os dados do cadastro e perguntar se vai usar os mesmos ou recolocar
    }
    sair
    {
        
    }
}
-cadastrar-se{nome,CPF,RG,CEP,telefone,data de nascimento,senha,confirmação,escreva algo para lembrar a senha, entrar...}

-configurações{idioma}
*******************************************************************************/
using System;
using System.IO;
class trabalhofarmacia 
{
  static void Main() 
  {
    Console.Clear();
    Console.BackgroundColor = ConsoleColor.White;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Black;
    
    metodos obj_farm = new metodos();
    escolhauser obj_escolha = new escolhauser();
    
    string hora = DateTime.Now.ToString("HH");
    int HORA = Convert.ToInt32(hora);
    int Hora = HORA-3;
    
    if (Hora<12 & Hora>=00)
    {
        string texto=" Bom dia, Seja Bem-Vindo";
        obj_farm.Perfumaria(texto);
        obj_escolha.Escolha_user();
    }
    else if (Hora>=12 & Hora<18)
    {
        string texto=" Boa tarde, Seja Bem-Vindo";
        obj_farm.Perfumaria(texto);
        obj_escolha.Escolha_user();
    }
    else if (Hora>=18 & Hora<23)
    {
        string texto=" Boa Noite, Seja Bem-Vindo";
        obj_farm.Perfumaria(texto);
        obj_escolha.Escolha_user();
    }
    
  }
}
