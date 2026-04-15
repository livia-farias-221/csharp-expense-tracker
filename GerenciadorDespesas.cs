namespace csharp_expense_tracker;
using System.Collections.Generic;

public class GerenciadorDespesas{

    public void ManipularDespesas(Dictionary<string, List<(string Nome, decimal Valor)>> gastosDicionario){
    
    

    string opcaoMenu = "";
    string opcaoSomar = "";
    string selecionarCategoria = "";
    
    while (true)

    {
        Console.WriteLine("O que deseja fazer agora?");
        Console.WriteLine("1-Listar despesas por categoria\n2-Excluir despesa\n3-Excluir categoria\n4-Editar nome de uma categoria\n5-Editar valor de um gasto\n6-Excluir um gasto\n7-Encerrar");
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
                Console.WriteLine($"{gasto.Nome} : R$ {gasto.Valor}");
            }

                Console.WriteLine("Gostaria de soma as despesas dessa categoria? (S/N)");
                opcaoSomar = Console.ReadLine();
                opcaoSomar = opcaoSomar.ToUpper();

                if (opcaoSomar == "S")
                {
                    decimal somarGastosCategoria = 0;
                    foreach (var gasto in gastosDicionario[selecionarCategoria])
                    {
                        somarGastosCategoria += gasto.Valor;
                    }

                    Console.WriteLine($"Total da categoria {selecionarCategoria}: R$ {somarGastosCategoria}");
                    continue;
                }

                else if (opcaoSomar == "N"){
                    continue;
                }

                else{
                    Console.WriteLine("Opção inválida. Digite novamente.");
                    continue;
                }

        }

        else if (opcaoMenu == "7"){
            Console.WriteLine("Encerrando...");
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

