using System;
using System.IO;
class conf
{
  //escolhauser obj_idioma_voltar = new escolhauser();
  methods obj_metodos = new methods ();
  public string Conf ()
  {
    Console.Clear ();
    string txte = "\t\tSettings";
    string txt_entrar = "\t     Drogaria Só Remédio";
      obj_metodos.Perfumaria (txte);
        try
        {
            Console.WriteLine (" What do you want to configure?");
            obj_metodos.Corsinha ("1");
            Console.WriteLine ("Language");
            obj_metodos.Corsinha ("2");
            Console.WriteLine ("About");
              
            Console.Write ("  -");
            int escolha_confg = Convert.ToInt32 (Console.ReadLine ());
            if (escolha_confg == 1)
            {
                Console.Clear ();
                string texto = "\tLanguage Settings";
                obj_metodos.Perfumaria (texto);
                Console.WriteLine (" Available languages: ");
                obj_metodos.Corsinha ("1");
                Console.WriteLine ("Portuguese");
                obj_metodos.Corsinha ("2");
                Console.WriteLine ("English");
                Console.Write ("  -");
                string escolha_idioma = Console.ReadLine ();
                if (escolha_idioma == "1")
                {
                    return ("4");
                }
                else if (escolha_idioma == "2")
                {
                    Console.Clear ();
                }
                else
                {
                  Console.WriteLine (" Invalid option!");
                  Console.WriteLine (" Press enter to go back.");
                  Console.ReadLine ();
                }
            }
            else if(escolha_confg==2)
            {
                Console.Clear();
                obj_metodos.Perfumaria(txt_entrar);
                obj_metodos.About();
            }
            else
            {
                Console.WriteLine (" Invalid option!");
                Console.WriteLine (" Press enter to go back.");
                Console.ReadLine ();
            }
        }
        catch (Exception e)
        {
            Console.Clear ();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine ("\n\t *Erro! *");
            Console.WriteLine ("\t" + e.Message);
        }
    return ("0");
  }
}
