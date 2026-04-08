namespace csharp_expense_tracker;

public class Despesas
{
    public void MostrarMenuCategorias(){
    
    Console.WriteLine("Primeiro vamos categorizar suas despesas");
    Console.WriteLine("Quais categorias você gostaria de adicionar?");
    Console.WriteLine("Exemplos:\n 1.Transporte\n 2.Alimentação\n 3.Hobbies\n 4.Saúde\n 5.Entretenimento\n 6.Beleza");
    
    Console.WriteLine("Gostaria de adiconar agora? (S/N)");
    string opcao = Console.ReadLine();

    while (opcao != "N" )
    {
        Console.WriteLine("Digite o nome da categoria: ");
        string categoria = Console.ReadLine();
        Console.WriteLine("Gostaria de adicionar mais uma categoria? (S/N)");
        opcao = Console.ReadLine();
        opcao = opcao.ToUpper();


        
    }

    }


}


