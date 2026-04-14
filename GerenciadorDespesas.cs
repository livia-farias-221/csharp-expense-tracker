namespace csharp_expense_tracker;
using System.Collections.Generic;

public class GerenciadorDespesas{

    public void ManipularDespesas(Dictionary<string, List<string>> gastosDicionario){
    
    Console.WriteLine("O que deseja fazer agora?");
    Console.WriteLine("1-Listar despesas por categoria\n 2-Excluir despesa\n 3-Excluir categoria\n 4-Editar nome de uma categoria\n 5-Editar valor de um gasto\n 6-Excluir um gasto");

    string opcaoMenu = "";
    string selecionarCategoria = "";
    
    while (true)

    {
        Console.WriteLine("Digite o número da opção: ");
        opcaoMenu = Console.ReadLine();
        
        if (opcaoMenu == "1")
        {
            Console.WriteLine("Digite o nome da categoria: ");
            selecionarCategoria = Console.ReadLine();
            
            if (!gastosDicionario.ContainsKey(selecionarCategoria))
            {
                Console.WriteLine("Categoria inválida! Por favor digite novamente.");
                continue;
            }
            
            foreach (var gasto in gastosDicionario[selecionarCategoria])
            {
                Console.WriteLine(gasto);
            }

            break;
        }

        else
        {
            //Console.WriteLine("Opção Inválida! Por favor digite novamente")
            break;
        }
        
    }

    }

}

