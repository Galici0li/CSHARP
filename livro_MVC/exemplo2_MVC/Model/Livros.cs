namespace std;

public class Livros
{
    // criar classe

    // atributos - caracteristicas
    // COLOCAR EM MAISCULO AS CARACTERISTICAS titulo, autor, numero de paginas = numPag 
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int NumPag { get; set; }

    // construtor
    public Livros(string titulo, string autor, int numPag)
    {
        // this = contexto = objeto = livro (classe)
        this.Titulo = titulo;  // onde quer armazenar = o que quer armazenar || caracteristica = declarado no construtor
        this.Autor = autor;
        this.NumPag = numPag;

        // atribuir a lista List<Livro> = adicionar quando tiver no repository 
        RepositoryLivros.Criar(this);
    }

    // metodos - funções
    // COLOCAR EM MAISCULO AS FUNÇÕES = MostrarLivro

    public void MostrarLivro()
    {
        System.Console.WriteLine($"O livro {Titulo} escrito por {Autor} tem {NumPag} páginas.\n");

    }
}