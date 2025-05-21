namespace std;   // view = interação do usuario , joga os dados para o controller

public class ViewPessoa // pedir pro usuario, armazenar e mandar para o controller
{

    public static void AdicionarPessoa()
    {

                    System.Console.WriteLine("Digite o nome da pessoa: ");
                    string nome = Console.ReadLine() ?? "";
                    System.Console.WriteLine("Digite a idade da pessoa: ");
                    int idade = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("Digite o email da pessoa: ");
                    string email = Console.ReadLine() ?? "";

                    ControllerPessoa.AdicionarPessoa(nome, idade, email);

                    System.Console.WriteLine("Cadastrado com sucesso!");
    }

     public static void ListarPessoa()
    {
                    List<Pessoa> pessoas = ControllerPessoa.ListarPessoa();
                    System.Console.WriteLine("------ Listando as pessoas ------");
                    foreach (Pessoa pessoa in pessoas) {
                        pessoa.MostrarDados();
                    }
                    System.Console.WriteLine("----------------------------------");
    }

     public static void AlterarPessoa()
    {
                    System.Console.WriteLine("\nInforme o INDEX da pessoa para alterar: ");
                    int idAlterar = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("Digite o novo nome da pessoa:");
                    pessoas[idAlterar].Nome = Console.ReadLine();
                    System.Console.WriteLine("Digite o novo email da pessoa:");
                    pessoas[idAlterar].Email = Console.ReadLine() ?? "";
                    System.Console.WriteLine("Digite a idade correta da pessoa:");
                    pessoas[idAlterar].Idade = Convert.ToInt32(Console.ReadLine());

                    ControllerPessoa.AlterarPessoa(nome, idade, email);

                    System.Console.WriteLine("Alterado com sucesso!");
        
    }

     public static void DeletarPessoa()
    {
                    System.Console.WriteLine("\nInforme o INDEX da pessoa para deletar: ");
                    int idDeletar = Convert.ToInt32(Console.ReadLine());
                     ControllerPessoa.DeletarPessoaPessoa(idDeletar);

                    System.Console.WriteLine("Deletado com sucesso!");
        
    }

}