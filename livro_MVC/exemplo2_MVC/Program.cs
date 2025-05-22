namespace std;

public class Program
{
    static void Main()
    {
        //CRUD
        System.Console.WriteLine("Bem vindo ao programa de livros!");

        int op = 0;

        do
        {

            System.Console.WriteLine("\n1 - Adicionar");
            System.Console.WriteLine("2 - Listar");
            System.Console.WriteLine("3 - Alterar");
            System.Console.WriteLine("4 - Deletar");
            System.Console.WriteLine("5 - Sair\n");
            op = Convert.ToInt32(Console.ReadLine()); // verificar aqui!!!!!!
            System.Console.WriteLine("\n");
            switch (op)
            {
                case 1:
                    // cramar view adicionar
                    ViewLivros.Criar();
                    break;

                case 2:
                    // chamar view listar
                    ViewLivros.Listar();
                    break;

                case 3:
                    // chamar view alterar
                    ViewLivros.Alterar();
                    break;

                case 4:
                    // chamar view deletar
                    ViewLivros.Deletar();
                    break;

                case 5:

                    System.Console.WriteLine("Saindo do Programa.");
                    break;
                default:
                    System.Console.WriteLine("Operação Inválida");
                    break;
            }

        } while (op != 5);

    }
}



