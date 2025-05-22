> dotnet new console

> dotnet run

> F1 > reload window

> cria as pastas > Model, View, Repository, Controller

> criar main no program > namespace std;
                        public class Program
                        {
                        static void Main()
                        {
                        }
                        }

> CRUD > criar switch case e do while 

criar opções do usuario > entre o do e o switch

> começar pelo model Mvc

criar classe s> caracteristicas funçoes e construtor > construtor é o nome da classe, nesse caso livro 

> ir para o repository mvc+R

criar a List<Livros> livro = new List<Livros> ();

adicionar as coisas na lista - criar, adicionar, listar e deletar. > 
public static void Criar()
    {
        
    }

listar não é void, é return 
public static List<Livros> Listar()
    {
        return livro;
    }

o resto é tudo void, sem retorno 

> voltar pra model e colocar a lista

this = o objeto, contexto que estamos trabalhando 
contexto = objeto = livro

> ir pra view mVc

colocar no program q vai chamar a view, dentro do switch case > ex
                    case 1:
                    ViewLivros.Criar();
                    break;

criar a view o q vai pedir pro usuario 

view não tem parametro, então não coloca nada no ()
ela mesma pega oq precisa, n precisa pegar nd de ninguem 

colocar o Writeline com as caracteristicas 

criar ReadLine com a variavel q é a caracteristica (pra saber onde armazenar a informação )= string, int ...

se for int sempre converte = Convert.ToInt32(Console.ReadLine()); 

chamar o controller pra armazenar as coisas na list 

criar > deletar > listar > alterar 

enviar oq a List tem q deletar no controller 
 
<!-- copiar o coiso do index de deletar pra por no alterar 
        System.Console.WriteLine("Digite o indice do livro para deletar: ");
        int index = Convert.ToInt16(Console.ReadLine()); -->

enviar oq tem q alterar na list 

ir pra o listar 

fazer o foreach 

chamar o controller para listar 

chamar o model pra mostrar a list, dentro do foreach > 
        foreach (Livros livros in livros)
        {
            livros.MostrarLivro();
        }

> ir para o controller mvC

criar o public static void pra cada item do CRUD 

deletar > criar > listar > alterar 

listar não é void, é return 

<!-- controller valida os dados 

validar dados = ver se existe oq quer ser alterado  -->





