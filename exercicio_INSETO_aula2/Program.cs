namespace std;

public class Program {

    public static void Main() {
        

        Inseto inseto = new Inseto("ET");
        inseto.ApresentarInsito();

        Aranha um = new Aranha("Marrom", 8);
        um.ApresentarInsito();


        Formiga dois = new Formiga("Vermelha");
        dois.ApresentarInsito();

    }
}
