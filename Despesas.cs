namespace csharp_expense_tracker;
using System.Collections.Generic;


public class Despesas
{
    public Dictionary<string, List<string>> AdicionarDespesas(){

    Dictionary<string,List<string>> gastosDicionario = new Dictionary<string, List<string>>() ;
    string opcao = "";

    Console.WriteLine("Primeiro vamos categorizar suas despesas.");
    Console.WriteLine();
    
 
    

        while (true)
        {
        
            Console.WriteLine("Qual categoria você gostaria de adicionar?");
            Console.WriteLine("Exemplos:\n 1.Transporte\n 2.Alimentação\n 3.Hobbies\n 4.Saúde\n 5.Entretenimento\n 6.Beleza");
            Console.WriteLine();
        
            Console.WriteLine("Digite o nome da categoria: ");
            string categoria = Console.ReadLine();
            Console.WriteLine();

            if (string.IsNullOrEmpty(categoria))
            {
                Console.WriteLine("Por favor digite o nome da categoria");
                Console.WriteLine();
                continue;
            }

            gastosDicionario[categoria] = new List<string>();
            
            Console.WriteLine("Gostaria de adicionar mais uma categoria? (S/N)");
            opcao = Console.ReadLine() ?? "";
            opcao = opcao.ToUpper();
            Console.WriteLine();

            if(opcao == "S")
            {
                continue;
                Console.WriteLine();
            }

            else if (string.IsNullOrEmpty(opcao))
            {
                Console.WriteLine("Por favor digite uma opção");
                Console.WriteLine();
                continue;
            }

            if (opcao == "N")
            {
                break;
            }

            else
            {
                Console.WriteLine("Por favor digite uma válida");
                Console.WriteLine();
                continue;
            }
    }

        Console.WriteLine("Agora vamos adicionar seus gastos");
        Console.WriteLine();
        Console.WriteLine("Categorias que você adicionou:");
    
        
        foreach (string categoria in gastosDicionario.Keys)
        {
            Console.WriteLine((categoria));

            
        }
        
        Console.WriteLine();
        
        string opcao2 = "";
        string opcao_categoria = "";
        string nome_despesa = "";
        string valor_despesa = "";
        //List<string> lista_nome_valor = new List<string>();

        while (true)
        {

            
            Console.WriteLine("Digite o nome da categoria");
            opcao_categoria = Console.ReadLine();
            Console.WriteLine();

            if (!gastosDicionario.ContainsKey(opcao_categoria))
            {
                Console.WriteLine("Categoria não existe");
                continue;
            }

            
            Console.WriteLine("Agora informe o nome da despesa.");
            nome_despesa = Console.ReadLine();
            Console.WriteLine();
            
            Console.WriteLine("Agora informe o valor da despesa.");
            valor_despesa = Console.ReadLine();
            //lista_nome_valor.Add(nome_despesa,valor_despesa);
            Console.WriteLine();
            
                        gastosDicionario[opcao_categoria].Add($"{nome_despesa} - {valor_despesa}");

            Console.WriteLine("Gostaria de adicionar mais algum gasto? (S|N)");
            opcao2 = Console.ReadLine();
            opcao2 = opcao2.ToUpper();

            if (opcao2 == "N")
            {
                break;
            }

            else if (string.IsNullOrEmpty(opcao2))
            {
                Console.WriteLine("Por favor digite uma opção");
                Console.WriteLine();
            }

            else if (opcao2 == "S")
            {
                Console.WriteLine();
                continue;
            }

            else
            {
                Console.WriteLine("Por favor digite uma opção válida");
                continue;
            }

            
        }
        
        
        

      Console.WriteLine();
      Console.WriteLine("Seus gastos:");
      foreach (var categoria in gastosDicionario)
    {
        Console.WriteLine($"Categoria: {categoria.Key}");
            foreach (var gasto in categoria.Value)
            {
                Console.WriteLine($"Gastos: {gasto}");
            }
        
    }
    
     return gastosDicionario;
 
    }


    }





