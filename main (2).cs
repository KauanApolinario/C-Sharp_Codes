/******************************************************************************

Kauan Guilherme Apolinário Costa Camargo N°15 1°A-TI

*******************************************************************************/
using System;
class Trabalho1  
{
  static void Main() 
  {
    Console.WriteLine("\n★★★★★★ HORÓSCOPO ★★★★★★\n");
    Console.Write("Digite o nome: ");
    string nome = Console.ReadLine();
    
    Console.Write("Digite a data de nascimento no formato DDMMAAAA: ");
    string data_nasc = Console.ReadLine();
    
    int dia = Convert.ToInt32 (data_nasc.Substring(0,2));
    int mes = Convert.ToInt32 (data_nasc.Substring(2,2));
    
    string[] meses = {"Janeiro","Fevereiro","Março","Abril","Maio","Junho","Julho","Agosto","Setembro","Outubro","Novembro","Dezembro"};
    string[] signos_g = {"♒ Aquário ♒","♓ Peixes ♓","♈ Áries ♈","♉ Touro ♉","♊ Gêmeos ♊","♋ Câncer ♋","♌ Leão ♌","♍ Virgem ♍","♎ Libra ♎","♏ Escorpião ♏","♐ Sagitário ♐","♑ Capricórnio ♑\n"};
    Console.WriteLine("\nOlá " + nome + "\n");
    Console.WriteLine("Essa é uma lista com todos os signos: \n");
    
    foreach(string signos in signos_g)
    {
    Console.WriteLine(signos);
    }
    
    if(mes==01)
    {
        if(dia>=01 & dia<=20)
        {
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.WriteLine("\nVocê é do signo de Capricórnio.");
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n");
        Console.WriteLine("\nPrincipais características: \n");
        Console.WriteLine("Nenhuma característica é capaz de definir melhor");
        Console.WriteLine("o capricorniano do que sua persistência.");
        Console.WriteLine("Forte, determinado e muito, muito persistente,");
        Console.WriteLine("os nativos deste signo são responsáveis");
        Console.WriteLine("por uma criatividade e imaginação invejável."); 
        Console.WriteLine("Capazes de qualquer coisa para conseguir o que querem,");
        Console.WriteLine("os capricornianos são pessoas persuasivas,");
        Console.WriteLine("controladoras e charmosas.");
        }
    }
    
    /*==========================================================================*/
                                        //Aquário//
    if(mes==01)
    {
        if(dia>=21 & dia<=31)
        {
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.WriteLine("\nVocê é do signo de Aquário.");
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n");
        Console.WriteLine("\nPrincipais características: \n");
        Console.WriteLine("Os aquarianos são conhecidos por ");
        Console.WriteLine("sua personalidade forte.");
        Console.WriteLine("Caracterizado como o primeiro,");
        Console.WriteLine("o signo de aquário é visto como");
        Console.WriteLine("um signo repleto de personalidade.");
        Console.WriteLine("os aquarianos são pessoas divertidas,");
        Console.WriteLine("companheiras e um tanto geniosas.");
        Console.WriteLine("Se você quer agradar um aquariano ");
        Console.WriteLine("estimule a sua inteligência,");
        Console.WriteLine("os aquarianos terão sua ");
        Console.WriteLine("valorização reconhecida.");
        }
    }
    
    if(mes==02)
    {
        if(dia>=01 & dia<=18)
        {
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.WriteLine("\nVocê é do signo de Aquário.");
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n");
        Console.WriteLine("\nPrincipais características: \n");
        Console.WriteLine("Os aquarianos são conhecidos por ");
        Console.WriteLine("sua personalidade forte.");
        Console.WriteLine("Caracterizado como o primeiro,");
        Console.WriteLine("o signo de aquário é visto como");
        Console.WriteLine("um signo repleto de personalidade.");
        Console.WriteLine("os aquarianos são pessoas divertidas,");
        Console.WriteLine("companheiras e um tanto geniosas.");
        Console.WriteLine("Se você quer agradar um aquariano ");
        Console.WriteLine("estimule a sua inteligência,");
        Console.WriteLine("os aquarianos terão sua ");
        Console.WriteLine("valorização reconhecida.");
        }
    }
    
    /*==========================================================================*/
                                        //peixes//
    if(mes==02)
    {
        if(dia>=19 & dia<=28)
        {
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.WriteLine("\nVocê é do signo de Peixes.");
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n");
        Console.WriteLine("\nPrincipais características: \n");
        Console.WriteLine("Os piscinianos costuma ser pessoas");
        Console.WriteLine("que adoram viver de ilusões.");
        Console.WriteLine("Vistos como serenos, os nascidos");
        Console.WriteLine("nesse signo costumam ser bastante");
        Console.WriteLine("sonhadores, talentosos e carentes");
        }
    }
    
    if(mes==03)
    {
        if(dia>=01 & dia<=20)
        {
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.WriteLine("\nVocê é do signo de Peixes.");
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n");
        Console.WriteLine("\nPrincipais características: \n");
        Console.WriteLine("Os piscinianos costuma ser pessoas");
        Console.WriteLine("que adoram viver de ilusões.");
        Console.WriteLine("Vistos como serenos, os nascidos");
        Console.WriteLine("nesse signo costumam ser bastante");
        Console.WriteLine("sonhadores, talentosos e carentes");
        }
    }
    
    /*==========================================================================*/
                                        //Áries//             
    if(mes==03)
    {
        if(dia>=21 & dia<=31)
        {
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.WriteLine("\nVocê é do signo de Áries.");
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n");
        Console.WriteLine("\nPrincipais características: \n");
        Console.WriteLine("O signo de áries pode ser definido como");
        Console.WriteLine("um dos signos mais conquistadores.");
        Console.WriteLine("Responsável por uma personalidade encantadora,");
        Console.WriteLine("os arianos são capazes de, com jeitinho,");
        Console.WriteLine("conquistar tudo aquilo que desejam.");
        Console.WriteLine("podemos destacar o lado conquistador,");
        Console.WriteLine("o excelente senso de humor");
        Console.WriteLine("e o charme dos arianos.");
        }
    }
    
    if(mes==04)
    {
        if(dia>=01 & dia<=19)
        {
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.WriteLine("\nVocê é do signo de Áries.");
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n");
        Console.WriteLine("\nPrincipais características: \n");
        Console.WriteLine("O signo de áries pode ser definido como");
        Console.WriteLine("um dos signos mais conquistadores.");
        Console.WriteLine("Responsável por uma personalidade encantadora,");
        Console.WriteLine("os arianos são capazes de, com jeitinho,");
        Console.WriteLine("conquistar tudo aquilo que desejam.");
        Console.WriteLine("podemos destacar o lado conquistador,");
        Console.WriteLine("o excelente senso de humor");
        Console.WriteLine("e o charme dos arianos.");
        }
    }
    
    /*==========================================================================*/
                                        //touro//
    if(mes==04)
    {
        if(dia>=20 & dia<=30)
        {
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.WriteLine("\nVocê é do signo de Touro.");
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n");
        Console.WriteLine("\nPrincipais características: \n");
        Console.WriteLine("Touro é considerado um dos signos mais fortes.");
        Console.WriteLine("Apesar de sua personalidade serena e tranquila,");
        Console.WriteLine("os taurinos costumas ser pessoas bem decididas");
        Console.WriteLine("e de fortes opiniões. Persistentes, lutadores");
        Console.WriteLine("e muito pacientes, eles estão sempre");
        Console.WriteLine("na busca constante por conquistas");
        Console.WriteLine("um de seus grandes defeitos é");
        Console.WriteLine("a falta de iniciativa,");
        Console.WriteLine("apesar da boa vontade");
        Console.WriteLine("os taurinos às vezes");
        Console.WriteLine("precisam daquele \"empurrãozinhio\"");
        }
    }
    
    if(mes==05)
    {
        if(dia>=01 & dia<=20)
        {
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.WriteLine("\nVocê é do signo de Touro.");
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n");
        Console.WriteLine("\nPrincipais características: \n");
        Console.WriteLine("Touro é considerado um dos signos mais fortes.");
        Console.WriteLine("Apesar de sua personalidade serena e tranquila,");
        Console.WriteLine("os taurinos costumas ser pessoas bem decididas");
        Console.WriteLine("e de fortes opiniões. Persistentes, lutadores");
        Console.WriteLine("e muito pacientes, eles estão sempre");
        Console.WriteLine("na busca constante por conquistas");
        Console.WriteLine("um de seus grandes defeitos é");
        Console.WriteLine("a falta de iniciativa,");
        Console.WriteLine("apesar da boa vontade");
        Console.WriteLine("os taurinos às vezes");
        Console.WriteLine("precisam daquele \"empurrãozinhio\"");
        }
    }
    
    /*==========================================================================*/
                                        //Gêmeos//
    if(mes==05)
    {
        if(dia>=21 & dia<=31)
        {
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.WriteLine("\nVocê é do signo de Gêmeos.");
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n");
        Console.WriteLine("\nPrincipais características: \n");
        Console.WriteLine("Os geminianos costumam gostar muito de dormir.");
        Console.WriteLine("Reconhecidos por muitos pelo sono excessivo,");
        Console.WriteLine("os geminianos são vistos algumas vezes");
        Console.WriteLine("como preguiçosos. O signo de gêmeos");
        Console.WriteLine("pode ser caracterizado como um signo");
        Console.WriteLine("bastante versátil. Dos geminianos");
        Console.WriteLine("podemos destacar seu companheirismo");
        Console.WriteLine("sua inteligência e sua estabilidade.");
        }
    }
    
    if(mes==06)
    {
        if(dia>=01 & dia<=21)
        {
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.WriteLine("\nVocê é do signo de Gêmeos.");
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n");
        Console.WriteLine("\nPrincipais características: \n");
        Console.WriteLine("Os geminianos costumam gostar muito de dormir.");
        Console.WriteLine("Reconhecidos por muitos pelo sono excessivo,");
        Console.WriteLine("os geminianos são vistos algumas vezes");
        Console.WriteLine("como preguiçosos. O signo de gêmeos");
        Console.WriteLine("pode ser caracterizado como um signo");
        Console.WriteLine("bastante versátil. Dos geminianos");
        Console.WriteLine("podemos destacar seu companheirismo");
        Console.WriteLine("sua inteligência e sua estabilidade.");
        }
    }
    
    /*==========================================================================*/
                                        //Câncer//
    if(mes==06)
    {
        if(dia>=22 & dia<=30)
        {
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.WriteLine("\nVocê é do signo de Câncer.");
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n");
        Console.WriteLine("\nPrincipais características: \n");
        Console.WriteLine("O signo mais maternal do zodíaco é responsável");
        Console.WriteLine("por personalidades doces e românticas.");
        Console.WriteLine("Muito relacionado a memórias e lembranças,");
        Console.WriteLine("os cancerianos são apaixonados pela família");
        Console.WriteLine("e adoram ficar em casa. Sensível, carinhoso");
        Console.WriteLine("e muito emotivo, o canceriano merece cuidado");
        Console.WriteLine("e atenção quando o assunto é relacionamento.");
        }
    }
    
    if(mes==07)
    {
        if(dia>=01 & dia<=22)
        {
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.WriteLine("\nVocê é do signo de Câncer.");
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n");
        Console.WriteLine("\nPrincipais características: \n");
        Console.WriteLine("O signo mais maternal do zodíaco é responsável");
        Console.WriteLine("por personalidades doces e românticas.");
        Console.WriteLine("Muito relacionado a memórias e lembranças,");
        Console.WriteLine("os cancerianos são apaixonados pela família");
        Console.WriteLine("e adoram ficar em casa. Sensível, carinhoso");
        Console.WriteLine("e muito emotivo, o canceriano merece cuidado");
        Console.WriteLine("e atenção quando o assunto é relacionamento.");
        }
    }
    
    /*==========================================================================*/
                                        //Leão//
    if(mes==07)
    {
        if(dia>=23 & dia<=31)
        {
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.WriteLine("\nVocê é do signo de Leão.");
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n");
        Console.WriteLine("\nPrincipais características: \n");
        Console.WriteLine("Fortes, livres e extravagantes, assim são");
        Console.WriteLine("as pessoas nascidas no signo de leão.");
        Console.WriteLine("Sempre a procurando se sobressair e");
        Console.WriteLine("chamar a atenção, os leoninos são conhecidos");
        Console.WriteLine("por suas ações luxuosas e extravagantes.");
        Console.WriteLine("Amantes de uma supervalorização,");
        Console.WriteLine("os nascidos nesse signo são");
        Console.WriteLine("responsáveis por um magnetismo");
        Console.WriteLine("de dar inveja.");
        }
    }
    if(mes==08)
    {
        if(dia>=01 & dia<=22)
        {
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.WriteLine("\nVocê é do signo de Leão.");
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n");
        Console.WriteLine("\nPrincipais características: \n");
        Console.WriteLine("Fortes, livres e extravagantes, assim são");
        Console.WriteLine("as pessoas nascidas no signo de leão.");
        Console.WriteLine("Sempre a procurando se sobressair e");
        Console.WriteLine("chamar a atenção, os leoninos são conhecidos");
        Console.WriteLine("por suas ações luxuosas e extravagantes.");
        Console.WriteLine("Amantes de uma supervalorização,");
        Console.WriteLine("os nascidos nesse signo são");
        Console.WriteLine("responsáveis por um magnetismo");
        Console.WriteLine("de dar inveja.");
        }
    }
    
    /*==========================================================================*/
                                        //Virgem//
    if(mes==08)
    {
        if(dia>=23 & dia<=31)
        {
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.WriteLine("\nVocê é do signo de Virgem.");
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n");
        Console.WriteLine("\nPrincipais características: \n");
        Console.WriteLine("Tímidos, perfeccionistas e bastante observadores,");
        Console.WriteLine("assim são os virginianos. Capazes de reparar");
        Console.WriteLine("em cada detalhe os nativos deste signo");
        Console.WriteLine("costumam ser um tanto meticulosos.");
        Console.WriteLine("Outra característica que pode ser");
        Console.WriteLine("facilmente observada nos nascidos");
        Console.WriteLine("no signo de virgem é a capacidade e");
        Console.WriteLine("obsessão por limpeza e organização.");
        Console.WriteLine("Os virginianos são vistos como os mais");
        Console.WriteLine("organizados do plano astral.");
        }
    }
    if(mes==09)
    {
        if(dia>=01 & dia<=22)
        {
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.WriteLine("\nVocê é do signo de Virgem.");
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n");
        Console.WriteLine("\nPrincipais características: \n");
        Console.WriteLine("Tímidos, perfeccionistas e bastante observadores,");
        Console.WriteLine("assim são os virginianos. Capazes de reparar");
        Console.WriteLine("em cada detalhe os nativos deste signo");
        Console.WriteLine("costumam ser um tanto meticulosos.");
        Console.WriteLine("Outra característica que pode ser");
        Console.WriteLine("facilmente observada nos nascidos");
        Console.WriteLine("no signo de virgem é a capacidade e");
        Console.WriteLine("obsessão por limpeza e organização.");
        Console.WriteLine("Os virginianos são vistos como os mais");
        Console.WriteLine("organizados do plano astral.");
        }
    }
    
    /*==========================================================================*/
                                        //Libra//
    if(mes==09)
    {
        if(dia>=23 & dia<=30)
        {
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.WriteLine("\nVocê é do signo de Libra.");
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n");
        Console.WriteLine("\nPrincipais características: \n");
        Console.WriteLine("Os nascidos sobre o signo de libra");
        Console.WriteLine("estão sempre em busca de harmonia");
        Console.WriteLine("e equilíbrio. Dotados de uma");
        Console.WriteLine("intuição forte e profunda");
        Console.WriteLine("os librianos costumam ser");
        Console.WriteLine("bastante cautelosos.");
        Console.WriteLine("Como as principais características");
        Console.WriteLine("podemos destacar o lado educado,");
        Console.WriteLine("gentil e charmoso.");
        }
    }
    if(mes==10)
    {
        if(dia>=01 & dia<=22)
        {
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.WriteLine("\nVocê é do signo de Libra.");
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n");
        Console.WriteLine("\nPrincipais características: \n");
        Console.WriteLine("Os nascidos sobre o signo de libra");
        Console.WriteLine("estão sempre em busca de harmonia");
        Console.WriteLine("e equilíbrio. Dotados de uma");
        Console.WriteLine("intuição forte e profunda");
        Console.WriteLine("os librianos costumam ser");
        Console.WriteLine("bastante cautelosos.");
        Console.WriteLine("Como as principais características");
        Console.WriteLine("podemos destacar o lado educado,");
        Console.WriteLine("gentil e charmoso.");
        }
    }
    
    /*==========================================================================*/
                                        //Escorpião//
    if(mes==10)
    {
        if(dia>=23 & dia<=31)
        {
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.WriteLine("\nVocê é do signo de Escorpião.");
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n");
        Console.WriteLine("\nPrincipais características: \n");
        Console.WriteLine("Os nativos do signo de escorpião abrem a");
        Console.WriteLine("sequência do zodíaco de signos de");
        Console.WriteLine("personalidade forte. Vistos como geniosos,");
        Console.WriteLine("meticulosos e muitas vezes teimosos,");
        Console.WriteLine("os escorpianos são pessoas que valorizam");
        Console.WriteLine("muito a própria opinião.");
        Console.WriteLine("Sedutores e muitos sensuais,");
        Console.WriteLine("os nascidos sob este signo costumam");
        Console.WriteLine("usar essas características para conquistar,");
        Console.WriteLine("com mais facilidade aquilo que desejam.");
        }
    }
    if(mes==11)
    {
        if(dia>=01 & dia<=21)
        {
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.WriteLine("\nVocê é do signo de Escorpião.");
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n");
        Console.WriteLine("\nPrincipais características: \n");
        Console.WriteLine("Os nativos do signo de escorpião abrem a");
        Console.WriteLine("sequência do zodíaco de signos de");
        Console.WriteLine("personalidade forte. Vistos como geniosos,");
        Console.WriteLine("meticulosos e muitas vezes teimosos,");
        Console.WriteLine("os escorpianos são pessoas que valorizam");
        Console.WriteLine("muito a própria opinião.");
        Console.WriteLine("Sedutores e muitos sensuais,");
        Console.WriteLine("os nascidos sob este signo costumam");
        Console.WriteLine("usar essas características para conquistar,");
        Console.WriteLine("com mais facilidade aquilo que desejam.");
        }
    }
    
    /*==========================================================================*/
                                        //Sagitário//
    if(mes==11)
    {
        if(dia>=22 & dia<=30)
        {
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.WriteLine("\nVocê é do signo de Sagitário.");
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n");
        Console.WriteLine("\nPrincipais características: \n");
        Console.WriteLine("Admirados por sua personalidade forte,");
        Console.WriteLine("os nativos de sagitário são pessoas");
        Console.WriteLine("bastante disciplinadas. Alegres e aventureiros,");
        Console.WriteLine("os sagitarianos estão sempre em busca");
        Console.WriteLine("de novas amizades e de novos horizontes.");
        Console.WriteLine("Assim como os virginianos,");
        Console.WriteLine("os nascidos sob este signo");
        Console.WriteLine("costumam ser bastante organizados.");
        }
    }
    if(mes==12)
    {
        if(dia>=01 & dia<=21)
        {
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.WriteLine("\nVocê é do signo de Sagitário.");
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n");
        Console.WriteLine("\nPrincipais características: \n");
        Console.WriteLine("Admirados por sua personalidade forte,");
        Console.WriteLine("os nativos de sagitário são pessoas");
        Console.WriteLine("bastante disciplinadas. Alegres e aventureiros,");
        Console.WriteLine("os sagitarianos estão sempre em busca");
        Console.WriteLine("de novas amizades e de novos horizontes.");
        Console.WriteLine("Assim como os virginianos,");
        Console.WriteLine("os nascidos sob este signo");
        Console.WriteLine("costumam ser bastante organizados.");
        }
    }
    
    /*==========================================================================*/
                                        //Capricórnio//
    if(mes==12)
    {
        if(dia>=22 & dia<=31)
        {
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.WriteLine("\nVocê é do signo de Capricórnio.");
        Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n");
        Console.WriteLine("\nPrincipais características: \n");
        Console.WriteLine("Nenhuma característica é capaz de definir melhor");
        Console.WriteLine("o capricorniano do que sua persistência.");
        Console.WriteLine("Forte, determinado e muito, muito persistente,");
        Console.WriteLine("os nativos deste signo são responsáveis");
        Console.WriteLine("por uma criatividade e imaginação invejável."); 
        Console.WriteLine("Capazes de qualquer coisa para conseguir o que querem,");
        Console.WriteLine("os capricornianos são pessoas persuasivas,");
        Console.WriteLine("controladoras e charmosas.");
        }
    }
    
    /*==========================================================================*/
                                        //O.B.S.//
    /*Todos os comandos "\n" foram utilizados unica e exclusivamente para
    uma melhor organização das informações. Sei que poderia ter optado por utilizar
    Console.WriteLine("");*/
    
    //Att: Kauan.
  }
}





