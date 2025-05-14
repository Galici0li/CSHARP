namespace std;

    public class Program {
        static void Main () {

            double A, B, C, base, altura, area;

            System.Console.WriteLine("Digite o valor de A: ");
            A=Convert.ToInt32(Console.ReadLine ());

            System.Console.WriteLine("Digite o valor de B: ");
            B=Convert.ToInt32(Console.ReadLine ());

            System.Console.WriteLine("Digite o valor de C: ");
            C=Convert.ToInt32(Console.ReadLine ());

            if (A+B>C||B+C>A||A+C>B) {
                System.Console.WriteLine("Os valores formam um triangulo. ");
            
            System.Console.WriteLine("Qual o valor da base do triangulo? ");
            base=Convert.ToInt32(Console.ReadLine ());

            System.Console.WriteLine("Qual o valor da altura do triangulo? ");
            altura=Convert.ToInt32(Console.ReadLine ());


            Calculadora.area;
            System.Console.WriteLine("O valor da area do triangulo é: "+area);
           
        }
        else {
            System.Console.WriteLine("Os valores não formam um triangulo");
        }
    }