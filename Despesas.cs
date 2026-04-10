namespace csharp_expense_tracker;
using System.Collections.Generic;


public class Despesas
{
    public void MostrarMenuCategorias(){

    Dictionary<string,List<string>> gastosDicionario = new Dictionary<string, List<string>>() ;
    string opcao = "";

    Console.WriteLine("Primeiro vamos categorizar suas despesas.");
 
    

        while (true)
        {
        
            Console.WriteLine("Qual categoria você gostaria de adicionar?");
            Console.WriteLine("Exemplos:\n 1.Transporte\n 2.Alimentação\n 3.Hobbies\n 4.Saúde\n 5.Entretenimento\n 6.Beleza");
        
            Console.WriteLine("Digite o nome da categoria: ");
            string categoria = Console.ReadLine();

            if (string.IsNullOrEmpty(categoria))
            {
                Console.WriteLine("Por favor digite o nome da categoria");
                continue;
            }

            gastosDicionario[categoria] = new List<string>();
            
            Console.WriteLine("Gostaria de adicionar mais uma categoria? (S/N)");
            opcao = Console.ReadLine() ?? "";
            opcao = opcao.ToUpper();

            if(opcao == "S")
            {
                continue;
            }

            else if (string.IsNullOrEmpty(opcao))
            {
                Console.WriteLine("Por favor digite uma opção");
                continue;
            }

            if (opcao == "N")
            {
                break;
            }

            else
            {
                Console.WriteLine("Por favor digite uma válida");
                continue;
            }
    }

   



      foreach (var item in gastosDicionario)
    {
        Console.WriteLine(item);
        
    }

 
    }


    }





