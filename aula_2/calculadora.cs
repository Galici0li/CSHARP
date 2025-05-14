namespace std;

public class calculadora {


    public static void Somar(int num1, int num2){
// public static TIPO (void = vazio. sem retorno) NOME (somar)
    System.Console.WriteLine("\n\tO resultado da soma é: " + (num1+num2));
    }

    public static int Sub(int num1, int num2) {
        return num1 - num2;
    }

    public static int Div(int num1, int num2) {
        return num1/num2;
    }

    public static int Multi(int num1, int num2) {
        return num1*num2;
    }
}