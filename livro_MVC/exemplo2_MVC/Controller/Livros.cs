namespace std;

public class ControllerLivros
{
    public static void Criar(string titulo, string autor, int numPag)
    {
        new Livros(titulo, autor, numPag); // isso ja atribui os valores ao objeto e armazena na list 
    }

    public static List<Livros> Listar()
    {
        // retorna uma lista - list
        return RepositoryLivros.Listar();
    }


    public static void Alterar(int index, string titulo, string autor, int numPag)
    {
        // validar dados 
        RepositoryLivros.Alterar(index, titulo, autor, numPag);
    }

    public static void Deletar(int index)
    {
        // validar dados 
        RepositoryLivros.Deletar(index);
    }
}