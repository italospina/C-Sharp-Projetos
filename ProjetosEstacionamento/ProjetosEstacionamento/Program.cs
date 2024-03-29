using ProjetosEstacionamento;
/// <summary>
/// Parte um do projeto
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        Apresentar apresentar = new Apresentar();
        apresentar.Apesentacao();

        Menu menu = new Menu();
        menu.ApesentarMenu();

    }
}