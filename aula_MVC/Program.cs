namespace std;

public class Program {

    static List<Pessoa> pessoas = new List<Pessoa>();  // agora é uma lista

    public static void Main() 
    {
        int op;

        System.Console.WriteLine($"Bem vindo(a) ao nosso programa de pessoas");
        do {
            System.Console.WriteLine($"\nDigite a opção desejada:");
            System.Console.WriteLine($"\t1 - Adicionar"); // segundo mais facil
            System.Console.WriteLine($"\t2 - Listar"); // mais facil
            System.Console.WriteLine($"\t3 - Alterar"); // quarto mais facil
            System.Console.WriteLine($"\t4 - Deletar");// terceito mais facil
            System.Console.WriteLine($"\t5 - Sair");
            op = Convert.ToInt32(Console.ReadLine());


            switch (op)
            {
                case 1: { 
                  
                    Pessoa pessoa = new Pessoa();
                    System.Console.WriteLine("Digite o nome da pessoa: ");
                    pessoa.Nome = Console.ReadLine() ?? "";
                    System.Console.WriteLine("Digite a idade da pessoa: ");
                    pessoa.Idade = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("Digite o email da pessoa: ");
                    pessoa.Email = Console.ReadLine() ?? "";
                    pessoas.Add(pessoa);
                    System.Console.WriteLine("Cadastrado com sucesso!");
                    break;
                }
                case 2: {
                    // listar as pessoas 
                    System.Console.WriteLine("------ Listando as pessoas ------");
                    foreach (Pessoa pessoa in pessoas) {
                        pessoa.MostrarDados();
                    }
                    System.Console.WriteLine("----------------------------------");
                    break;
                }
                case 3: {
                    // System.Console.WriteLine("\nInforme o INDEX da pessoa para alterar: ");
                    // int idMudar = Convert.ToInt32(Console.ReadLine());

                    // do {
                    //     System.Console.WriteLine("\nInforme o que deseja alterar: ");
                    //     string idAlterar = Console.ReadLine();

                    
                    //     if (pessoas [idAlterar] = Nome){
                    //         System.Console.WriteLine("Digite o novo nome desejado: ");
                    //         pessoa.Nome = Console.ReadLine() ?? "";
                    //     }
                    // }

                    System.Console.WriteLine("\nInforme o INDEX da pessoa para alterar: ");
                    int idAlterar = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("Digite o novo nome da pessoa:");
                    pessoas[idAlterar].Nome = Console.ReadLine();
                    System.Console.WriteLine("Digite o novo email da pessoa:");
                    pessoas[idAlterar].Email = Console.ReadLine() ?? "";
                    System.Console.WriteLine("Digite a idade correta da pessoa:");
                    pessoas[idAlterar].Idade = Convert.ToInt32(Console.ReadLine());


                    break;
                }
                case 4: {
                    // deletar uma posição do meu array, qual a posição?
                    System.Console.WriteLine("\nInforme o INDEX da pessoa para deletar: ");
                    // variavel 
                    int idDeletar = Convert.ToInt32(Console.ReadLine());
                    pessoas.RemoveAt(idDeletar);
                    System.Console.WriteLine("Deletado com sucesso!");

                    break;
                }
                case 5: {
                    System.Console.WriteLine("Saindo do programa");
                    break;
                }
                default : {
                    break;
                }
            }
        }while (op != 5);
    }
}