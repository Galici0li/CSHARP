namespace std;

public class Program {

    // public static void Main() {
    //     System.Console.WriteLine("Teste");
    //     Pessoa teste = new Pessoa(); // instanciando uma nova Pessoa 
    //     teste.Email = "testando@email.com";
    //     teste.Nome = "Jão";
    //     teste.Idade = 12;
    //     teste.MostrarDados();

    // }

        // Array --- começa na posição 0
    public static void Main() {
        Pessoa[] pessoas = new Pessoa[100];
        int op; // int do switch case
        System.Console.WriteLine($"Bem vindo(a) ao nosso programa de pessoas");
        do {
            System.Console.WriteLine($"\nDigite a opção desejada:");
            System.Console.WriteLine($"\t1 - Adicionar");
            System.Console.WriteLine($"\t2 - Listar");
            System.Console.WriteLine($"\t3 - Alterar");
            System.Console.WriteLine($"\t4 - Deletar");
            System.Console.WriteLine($"\t5 - Sair");
            op = Convert.ToInt32(Console.ReadLine());


            switch (op)
            {
                case 1: {
                    break;
                }
                case 2: {
                    break;
                }
                case 3: {
                    break;
                }
                case 4: {
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
        } while (op != 5);

}
}
