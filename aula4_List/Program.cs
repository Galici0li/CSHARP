namespace std;
 
public class Program {
    //tipo nomeVariavel;
    //static List<tipo que quero armazenar> nomeVariavel = new List<tipo> (); | List<int>
    //Uma lista para armazenar strings
 
    static List<string> nomes = new List<string>();
    static void Main(){
        Console.WriteLine("--------------------- CRIANDO ---------------------");
 
        nomes.Add("Ana");
        nomes.Add("Bruno");
        nomes.Add("Gerald");
        nomes.Add("Ana");
 
        foreach (string nome in nomes) {
            Console.WriteLine(nome);
        }        
          Console.WriteLine("--------------------- ALTERANDO ---------------------");
          nomes[2] = "Batata";
 
        foreach (string nome in nomes) {
            Console.WriteLine(nome);
        }
 
        Console.WriteLine("--------------------- DELETANDO ---------------------");
        //COMO DELETAR
        nomes.RemoveAt(0); //primeira Ana é 0
       
        foreach (string nome in nomes) {
            Console.WriteLine(nome);
        }        
    }
   
}
 
 
// foreach (var item in collection)
//var é a variavel que vou colocar: int / char / string /
//item é onde o programa salva a variavel da lista toda vez que repete
//collection é o nome da lista
//no Console vamos colocar o que vai ser impresso, no caso o nome
