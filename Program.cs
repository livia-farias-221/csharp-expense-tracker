using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Bem vindo(a) ao rastreador de despesas!");
            Console.WriteLine("Qual o seu nome?");
            string nomeUsuario = Console.ReadLine();

            if (string.IsNullOrEmpty(nomeUsuario))
            {
                Console.WriteLine("Por favor informe seu nome.");
                continue;
            }
            
            Console.WriteLine("Rastreador de despesas de " + nomeUsuario);
            break;
        }

   
        
    Dictionary<string,List<(string Nome, decimal Valor)>> gastosDicionario = new Dictionary<string, List<(string Nome, decimal Valor)>>() ;
    string opcao = "";


    // Início adicionar categorias
    Console.WriteLine("Primeiro vamos categorizar suas despesas.");
    Console.WriteLine();
    
        while (true)
        {
        
            Console.WriteLine("Qual categoria você gostaria de adicionar?");
            Console.WriteLine("Exemplos:\n•Transporte\n•Alimentação\n•Hobbies\n•Saúde\n•Entretenimento\n•Beleza");
            Console.WriteLine();
        
            Console.WriteLine("Digite o nome da categoria: ");
            string categoria = Console.ReadLine();
            categoria = categoria.ToUpper();
            Console.WriteLine();

            if (string.IsNullOrEmpty(categoria))
            {
                Console.WriteLine("Por favor digite o nome da categoria");
                Console.WriteLine();
                continue;
            }

            gastosDicionario[categoria] = new List<(string Nome, decimal Valor)>();
            
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

    // Fim adicionar categorias

    //Início adicionar gastos

        
        
        string opcao2 = "";
        string opcao_categoria = "";
        string nome_despesa = "";
        decimal valor_despesa = 0;
        string opcaoDespesa = "";
        

        while (true)
        {   Console.WriteLine("Gostaria de adicionar uma despesa (S/N)?");
            opcaoDespesa = Console.ReadLine();
            opcaoDespesa = opcaoDespesa.ToUpper();

            if (opcaoDespesa == "S")
            {
            Console.WriteLine("Adicionar seus gastos");
            Console.WriteLine();
            Console.WriteLine("Categorias que você adicionou:");
    
        
        foreach (string categoria in gastosDicionario.Keys)
        {
            Console.WriteLine((categoria));

            
        }
        
        Console.WriteLine();
            
            Console.WriteLine("Digite o nome da categoria");
            opcao_categoria = Console.ReadLine();
            opcao_categoria = opcao_categoria.ToUpper();
            Console.WriteLine();

            if (!gastosDicionario.ContainsKey(opcao_categoria))
            {
                Console.WriteLine("Categoria não existe");
                continue;
            }

            else{
                     
                Console.WriteLine("Agora informe o nome da despesa.");
                nome_despesa = Console.ReadLine();
                nome_despesa = nome_despesa.ToLower();
                Console.WriteLine();
                
                Console.WriteLine("Agora informe o valor da despesa.\nObs: utilize apenas números e, se for digitar casas decimais, utilize ponto (.) ao invés de vírgula (,)");
                valor_despesa = decimal.Parse(Console.ReadLine());
                
                
                Console.WriteLine();
                
                gastosDicionario[opcao_categoria].Add((nome_despesa, valor_despesa));
                while (true)
                {
                    Console.WriteLine("Gostaria de adicionar mais algum gasto nessa categoria? (S|N)");
                    opcao2 = Console.ReadLine();
                    opcao2 = opcao2.ToUpper();

                    if (opcao2 == "N")
                    {   Console.WriteLine("Você será redirecionado para adicionar em outra categoria ou para ir para o próximo menu de opções");
                        break;
                    }

                    else if (string.IsNullOrEmpty(opcao2))
                    {
                        Console.WriteLine("Por favor digite uma opção");
                        Console.WriteLine();
                    }

                    else if (opcao2 == "S")
                    {
                       Console.WriteLine("Informe o nome da despesa.");
                        nome_despesa = Console.ReadLine();
                        nome_despesa = nome_despesa.ToLower();
                        Console.WriteLine();
                        
                        Console.WriteLine("Informe o valor da despesa.");
                        valor_despesa = decimal.Parse(Console.ReadLine());
                        Console.WriteLine();
                        
                        gastosDicionario[opcao_categoria].Add((nome_despesa, valor_despesa));
                        continue;
                    }

                    else
                    {
                        Console.WriteLine("Por favor digite uma opção válida");
                        continue;
                    }

                    }
                    

                    

            }

       
            }

            else if (opcaoDespesa == "N"){
                break;
            }

            else if (string.IsNullOrEmpty(opcaoDespesa))
            {
                Console.WriteLine("Por favor digite uma opção");
                continue;
            }

            else
            {
                Console.WriteLine("Opção inválida. Por favor tente novamente.");
                continue;
            }
            {
                
            }
            
            
        }

    //Fim adicionar gastos    

    // Imprimindo todos os gastos

      Console.WriteLine();
      Console.WriteLine("Seus gastos:");
      foreach (var categoria in gastosDicionario)
    {
        Console.WriteLine($"Categoria: {categoria.Key}");
            foreach (var gasto in categoria.Value)
            {
                Console.WriteLine($"{gasto.Nome} : R$ {gasto.Valor:F2}");
            }
        
    }

    //Início manipulação dos dados 

    string opcaoMenu = "";
    string opcaoSomar = "";
    string selecionarCategoria = "";
    decimal somarGastosGerais = 0;
    string selecionarCategoriaDeletar = "";
    string gastoDeletar = "";
    
    while (true)

    {
        Console.WriteLine("O que deseja fazer agora?");
        Console.WriteLine("1-Listar e somar despesas por categoria\n2-Somar em geral\n3-Excluir despesa\n4-Excluir categoria\n5-Encerrar");
        Console.WriteLine("Digite o número da opção: ");
        opcaoMenu = Console.ReadLine();
        
        if (opcaoMenu == "1")
        {   
            Console.WriteLine("Catgorias que você adicionou");
            foreach (string categoria in gastosDicionario.Keys)
            {
                Console.WriteLine((categoria));

                
            }
        
            Console.WriteLine();
            Console.WriteLine("Digite o nome da categoria: ");
            selecionarCategoria = Console.ReadLine();
            selecionarCategoria = selecionarCategoria.ToUpper();
            
            if (!gastosDicionario.ContainsKey(selecionarCategoria))
            {
                Console.WriteLine("Categoria inválida! Por favor digite novamente.");
                continue;
            }
            
            foreach (var gasto in gastosDicionario[selecionarCategoria])
            {
                Console.WriteLine($"{gasto.Nome} : R$ {gasto.Valor}");
            }

                Console.WriteLine("Gostaria de somar as despesas dessa categoria? (S/N)");
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

        else if (opcaoMenu =="2"){

                somarGastosGerais = 0; // zerar variável para evitar erros ao editar valores dentro do dicionário
                
                foreach (var listaDespesas in gastosDicionario.Values)
                {   
                    foreach(var despesa in listaDespesas)
                    {
                        somarGastosGerais += despesa.Valor;
                    }

                    }

                    Console.WriteLine($"Valor total das despesas: R$ {somarGastosGerais}");
                    continue;
                    

                }

        else if (opcaoMenu == "3")
        {
            Console.WriteLine("Categorias que você adicionou:");
            foreach (string categoria in gastosDicionario.Keys)
                {
                    Console.WriteLine((categoria));

                    
                }
        
            Console.WriteLine();
            Console.WriteLine("Digite o nome da categoria: ");
            selecionarCategoriaDeletar = Console.ReadLine();
            selecionarCategoriaDeletar = selecionarCategoriaDeletar.ToUpper();

            if (!gastosDicionario.ContainsKey(selecionarCategoriaDeletar)){
                Console.WriteLine("Essa categoria não existe. Por favor, tente novamente");
                continue;
            }

            else
            {
                Console.WriteLine("Gastos nessa categoria");
                
                foreach (var gasto in gastosDicionario[selecionarCategoriaDeletar]){
                    Console.WriteLine($" {gasto}");
                }

                Console.WriteLine("Digite o nome do gasto que deseja deletar:");
                gastoDeletar = Console.ReadLine();
                gastoDeletar = gastoDeletar.ToLower();

                var lista = gastosDicionario[selecionarCategoriaDeletar];
                var gastoParaRemover = lista.FirstOrDefault(g => g.Nome == gastoDeletar);

                if (gastoParaRemover.Nome == null){
                    Console.WriteLine("Gasto não encontrado");
                    continue;
                }

                else{
                    lista.Remove(gastoParaRemover);
                    Console.WriteLine("Gasto removido com sucesso!");
                    continue;
                }




                
            }
        }

        else if (opcaoMenu == "4")
        {
            Console.WriteLine("Categorias que você adicionou:");
            foreach (string categoria in gastosDicionario.Keys)
                {
                    Console.WriteLine((categoria));

                    
                }
        

            string categoriaRemover = "";
            Console.WriteLine("Digite o nome da categoria que deseja excluir: ");
            Console.WriteLine("Observação: todos os gastos também serão excluídos.");
            categoriaRemover = Console.ReadLine();
            categoriaRemover = categoriaRemover.ToUpper();

            if (!gastosDicionario.ContainsKey(categoriaRemover)){
                Console.WriteLine("Categoria não existe! Por favor digite novamente.");
                continue;
            }

            else
            {
                gastosDicionario.Remove(categoriaRemover);
                Console.WriteLine("Categoria removida.");
            }

        }
               

        

        else if (opcaoMenu == "5"){
            Console.WriteLine("Encerrando...");
            break;
        }

        else
        {
            //Console.WriteLine("Opção Inválida! Por favor digite novamente")
            continue;
        }
        
    }

    // Fim Maniupulaçao de gastos

    }
}
