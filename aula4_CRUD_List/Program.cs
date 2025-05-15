namespace std;
 
public class Program {
    static List<string> nomes = new List<string>();
    static void Main() {
        int op;
        Console.WriteLine("Bem-vindo(a) ao nosso programar de pessoas para pessoas");
        do {
            Console.WriteLine("\n\nDigite a opção desejada:\n");
            Console.WriteLine("\t1 - Adicionar");
            Console.WriteLine("\t2 - Listar");
            Console.WriteLine("\t3 - Alterar");
            Console.WriteLine("\t4 - Deletar");
            Console.WriteLine("\t5 - Sair");
            op = Convert.ToInt32(Console.ReadLine());
 
            switch (op) {
                case 1 : {
                    CriarNome();
                    // nomes.Add(Console.ReadLine() ?? "");
                    break;
                }
                case 2 : {
                    ListarNome();
                    
                    break;
                }
                case 3 : {
                    AlterarNome();
                    break;
                }
                case 4 : {
                     DeletarNome();
                    break;
                }
                case 5 : {
                    Console.WriteLine("Saindo do programa");
                    break;
                }
                default : {
                    break;
                }
            }
        } while (op != 5);
    }

    public static void CriarNome() {
        Console.WriteLine("--------------------------\nDigite um nome: ");
        string nome = Console.ReadLine() ?? "";
        nomes.Add(nome);
        }

    public static void ListarNome() {
        Console.WriteLine("---- Listando ----");
        int aux = 0; //mostra a posição na lista
        foreach(string nome in nomes) {
            System.Console.Write(aux); // mostra a posição na lista
            Console.WriteLine(nome);
            aux ++; // mostra a posição na lista
        }

        Console.WriteLine("----------------");   
    }

    public static void AlterarNome() {
        System.Console.WriteLine("-------------------------\nInforme o Index da pessoa que deseja alterar: ");
        int idAlterar = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Digite o novo nome: ");
        nomes[idAlterar] = Console.ReadLine() ?? "";
        System.Console.WriteLine("Pessoa alterada com sucesso!\n---------------------------------------");
        
    }

    public static void DeletarNome() {
        System.Console.WriteLine("-----------------\nInforme o Index da pessoa que deseja deletar");
        int idDeletar = Convert.ToInt32(Console.ReadLine());
        nomes.RemoveAt(idDeletar);
        System.Console.WriteLine("Pessoa deletada com sucesso!\n---------------------------------------");
    }

}
