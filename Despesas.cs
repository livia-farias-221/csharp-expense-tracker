namespace csharp_expense_tracker;
using System.Collections.Generic;


public class Despesas
{
    public void MostrarMenuCategorias(){

    Dictionary<string,List<string>> gastosDicionario = new Dictionary<string, List<string>>() ;
    
    Console.WriteLine("Primeiro vamos categorizar suas despesas");
    Console.WriteLine("Quais categorias você gostaria de adicionar?");
    Console.WriteLine("Exemplos:\n 1.Transporte\n 2.Alimentação\n 3.Hobbies\n 4.Saúde\n 5.Entretenimento\n 6.Beleza");
    
    Console.WriteLine("Gostaria de adicionar agora? (S/N)");
    string opcao = Console.ReadLine();
    opcao = opcao.ToUpper();
    if (opcao == "S")
    {

        while (opcao != "N" )
    {
        Console.WriteLine("Digite o nome da categoria: ");
        string categoria = Console.ReadLine();
        
        gastosDicionario[categoria] = new List<string>();
        
        Console.WriteLine("Gostaria de adicionar mais uma categoria? (S/N)");
        opcao = Console.ReadLine() ?? "";
        opcao = opcao.ToUpper();
    }

  
    }

      else if (opcao == "N")
    {
        Console.WriteLine("Encerrando programa...");
        
    }

 
        

    foreach (var item in gastosDicionario)
    {
        Console.WriteLine(item);
        
    }


    }


}


