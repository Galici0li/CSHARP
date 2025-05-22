namespace std;

public class RepositoryLivros
{
    static List<Livros> livros = new List<Livros>();

    public static void Criar(Livros Livros)
    {
        livros.Add(Livros);
    }

    public static List<Livros> Listar()
    {
        return livros;
    }

    public static void Alterar( int index, string titulo, string autor, int numPag)
    {
        livros[index].Titulo = titulo;
        livros[index].Autor = autor; 
        livros[index].NumPag = numPag; 
    }
    
    public static void Deletar(int index)  // é um encapsulamento 
    {
        livros.RemoveAt(index);
    }

}