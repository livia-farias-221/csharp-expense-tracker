using csharp_expense_tracker;

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

       

        Despesas despesas = new Despesas();
        despesas.AdicionarDespesas();

    }
}
