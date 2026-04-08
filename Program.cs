using csharp_expense_tracker;

class Program
{
    static void Main()
    {

        Console.WriteLine("Bem vindo(a) ao rastreador de despesas!");
        Console.WriteLine("Qual o seu nome?");
        string nomeUsuario = Console.ReadLine();
        Console.WriteLine("Rastreador de despesas de " + nomeUsuario);

        Despesas despesas = new Despesas();
        despesas.MostrarMenuCategorias();

    }
}
