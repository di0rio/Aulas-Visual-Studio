using Listas;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===== TRABALHANDO COM LISTAS SIMPLES ====== \n\n");

        List<string> listaFrutas = new List<string>();

        Console.WriteLine("Adicionando Itens na Lista: \n");
        listaFrutas.Add("Banana");
        listaFrutas.Add("Maçã");
        listaFrutas.Add("Morango");
        listaFrutas.Add("Uva");
        listaFrutas.Add("Abacaxi");

        Console.WriteLine("Imprimindo a Lista de Frutas:");
        foreach (var fruta in listaFrutas)
        {
            Console.WriteLine(fruta);
        }

        Console.WriteLine("\nExibindo Item Específico da Lista:");
        Console.WriteLine(listaFrutas[2]);

        Console.WriteLine("\nInserir Item em posição específica na Lista:");
        listaFrutas.Insert(2, "Laranja");

        Console.WriteLine("Imprimindo a Lista de Frutas:");
        foreach (var fruta in listaFrutas)
        {
            Console.WriteLine(fruta);
        }

        Console.WriteLine("\nAlterar Item da Lista:");
        listaFrutas[2] = "Melancia";

        Console.WriteLine("\nExibindo Item Específico da Lista:");
        Console.WriteLine(listaFrutas[2]);

        Console.WriteLine("\nRemovendo Item a Lista de Frutas por Indice:");
        Console.WriteLine(listaFrutas[3]);
        listaFrutas.RemoveAt(3);
        Console.WriteLine(listaFrutas[3]);

        Console.WriteLine("\nRemovendo Item a Lista de Frutas por Valor:");
        listaFrutas.Remove("Banana");
        Console.WriteLine("Imprimindo a Lista de Frutas:");
        foreach (var fruta in listaFrutas)
        {
            Console.WriteLine(fruta);
        }

        Console.WriteLine("\nExcluir todos os Itens Existentes na Lista:");
        listaFrutas.Clear();


        Console.WriteLine("\n\n===== TRABALHANDO COM LISTAS DE OBJETOS ====== \n\n");

        Aluno aluno1 = new Aluno("João", "joao@teste.com", 123);
        Aluno aluno2 = new Aluno("Maria", "maria@senai.br", 456);
        Aluno aluno3 = new Aluno("José", "jose@email.com", 789);

        List<Aluno> listaAlunos = new List<Aluno>();
        listaAlunos.Add(aluno1);
        listaAlunos.Add(aluno2);
        listaAlunos.Add(aluno3);

        Console.WriteLine("\nImprimindo a Lista de Alunos:");
        foreach (var aluno in listaAlunos)
        {
            Console.WriteLine($"Nome: {aluno.Nome} - Email: {aluno.Email} - RM: {aluno.RM}");
        }

        Console.WriteLine("\nAlterando Itens na Lista:");
        listaAlunos[0].Nome = "João da Silva";
        listaAlunos[1] = new Aluno("Maria da Silva", "maria@email.com", 999);

        Console.WriteLine("\nImprimindo a Lista de Alunos:");
        foreach (var aluno in listaAlunos)
        {
            Console.WriteLine($"Nome: {aluno.Nome} - Email: {aluno.Email} - RM: {aluno.RM}");
        }

        Console.WriteLine("\nRemovendo Itens na Lista:");
        listaAlunos.RemoveAt(1);

        Console.WriteLine("\nImprimindo a Lista de Alunos:");
        foreach (var aluno in listaAlunos)
        {
            Console.WriteLine($"Nome: {aluno.Nome} - Email: {aluno.Email} - RM: {aluno.RM}");
        }

        listaAlunos.Remove(aluno3);
        Console.WriteLine("\nImprimindo a Lista de Alunos:");
        foreach (var aluno in listaAlunos)
        {
            Console.WriteLine($"Nome: {aluno.Nome} - Email: {aluno.Email} - RM: {aluno.RM}");
        }

        listaAlunos.Clear();

    }
}