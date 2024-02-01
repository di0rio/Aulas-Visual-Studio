using Aula02;

internal class Program
{
    private static void Main(string[] args)
    {
        Personagem p1 = new Personagem("Gandalf", "Mago", 1, 10, 7, 10, 100);
        p1.ApresentarSe();

        Personagem p2 = new Personagem("Legolas", "Arqueiro", 1, 5, 20, 5, 100);
        p2.ApresentarSe();

        Personagem p3 = new Personagem("Gimli", "Guerreiro", 3, 20, 30, 10, 100);
        p3.ApresentarSe();

        Personagem p4 = new Personagem("Aragorn", "Guerreiro", 4, 30, 20, 25, 100);
        p4.ApresentarSe();

        p1.Duelo(p3);
    }
}