namespace std;

public class Program{
    static void Main () {

        int num;

        Console.WriteLine("Digite o número que deseja a tabuada:");
        num=Convert.ToInt32(Console.ReadLine ());

        Calculadora.tabuada(num);
    }
}

