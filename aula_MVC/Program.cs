namespace std;          //program = estrutura (switch case, do while...), joga os dados para a view

// enviando informação = program > view > controller > model ou repository
// retornando informação = program < view < controller < model ou repository


public class Program {

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


            switch (op)   // dentro do case a função da view
            {
                case 1: { 
                  
                    ViewPessoa.AdicionarPessoa(); // chamei o q tem na view pessoa, ent qnd quiser adicionar vai entrar no case 1 e ir pra view pessoa

                    break;
                }
                case 2: {
                    
                    ViewPessoa.ListarPessoa();

                    break;
                }
                case 3: {
             
                    ViewPessoa.AlterarPessoa();
                    // System.Console.WriteLine("\nInforme o INDEX da pessoa para alterar: ");
                    // int idAlterar = Convert.ToInt32(Console.ReadLine());
                    // System.Console.WriteLine("Digite o novo nome da pessoa:");
                    // pessoas[idAlterar].Nome = Console.ReadLine();
                    // System.Console.WriteLine("Digite o novo email da pessoa:");
                    // pessoas[idAlterar].Email = Console.ReadLine() ?? "";
                    // System.Console.WriteLine("Digite a idade correta da pessoa:");
                    // pessoas[idAlterar].Idade = Convert.ToInt32(Console.ReadLine());


                    break;
                }
                case 4: {
                    // deletar uma posição do meu array, qual a posição?
                    // System.Console.WriteLine("\nInforme o INDEX da pessoa para deletar: ");
                    // // variavel 
                    // int idDeletar = Convert.ToInt32(Console.ReadLine());
                    // pessoas.RemoveAt(idDeletar);
                    // System.Console.WriteLine("Deletado com sucesso!");

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