namespace std;                    // pasta controller = receber valores, validar e criar objeto , joga os dados para a model e chama o repository, ou vice versa

public class ControllerPessoa {

    public static void AdicionarPessoa(
        //receber valores 
        string nome,
        int idade,
        string email 
    ) 
    {
        // criar objeto 
        new Pessoa(nome, idade, email); 

    } 

    public static List<Pessoa> ListarPessoa() 
    {
        return RepositoryPessoa.ListarPessoa();
    }

    public static void AlterarPessoa() 
    {
        RepositoryPessoa.AlterarPessoa();

    }

    public static void DeletarPessoa(int index) 
    {
        RepositoryPessoa.DeletarPessoa(index);
    }

}