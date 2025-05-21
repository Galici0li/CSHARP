namespace std;   // repository = acesso e manipulação dos dados ao banco

public class RepositoryPessoa{

    static List<Pessoa> pessoas = new List<Pessoa>();  

    public static void AdicionarPessoa(Pessoa pessoa)
    {
        pessoas.Add(pessoa);
    }

     public static List<Pessoa> ListarPessoa()
    {
        return pessoas;
    }

     public static void AlterarPessoa()
    {
        pessoas.Alt(pessoa);
    }

     public static void DeletarPessoa(int index)
    {
        pessoas.RemoveAt(index);
    }



}