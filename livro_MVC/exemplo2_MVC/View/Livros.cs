namespace std;

public class ViewLivros
{

    public static void Criar()
    {
        System.Console.WriteLine("\nDigite o titulo do livro: ");
        string titulo = Console.ReadLine() ?? "";
        System.Console.WriteLine("\nDigite o autor do livro: ");
        string autor = Console.ReadLine() ?? "";
        System.Console.WriteLine("\nDigite a quantidade de páginas do livro: ");
        int numPag = Convert.ToInt32(Console.ReadLine());

        // chamar o controller.Criar() pra passar os dados 
        ControllerLivros.Criar(titulo, autor, numPag);
    }

    public static void Listar()
    {
        // pra listar tem q chamar o controller 

        List<Livros> livros = ControllerLivros.Listar();
        foreach (Livros livro in livros)
        {
            Console.Write(livros.IndexOf(livro) + $" : "); // mostra a posição da lista 
            livro.MostrarLivro(); // mostra a posição da lista 
        }  
    }

    public static void Alterar()
    {
        System.Console.WriteLine("\nDigite o indice do livro para alterar: ");
        int index = Convert.ToInt16(Console.ReadLine());
        System.Console.WriteLine("\nDigite o titulo do livro: ");
        string titulo = Console.ReadLine() ?? "";
        System.Console.WriteLine("\nDigite o autor do livro: ");
        string autor = Console.ReadLine() ?? "";
        System.Console.WriteLine("\nDigite a quantidade de páginas do livro: ");
        int numPag = Convert.ToInt32(Console.ReadLine());

        // chamar o controller pra alterar na list 
        ControllerLivros.Alterar(index, titulo, autor, numPag);
    }

    public static void Deletar()
    {
        System.Console.WriteLine("\nDigite o indice do livro para deletar: ");
        int index = Convert.ToInt16(Console.ReadLine());

        // enviar para o controller deletar da List 
        ControllerLivros.Deletar(index);
    }
    
    
}