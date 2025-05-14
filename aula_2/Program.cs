//cout = Console.Writeline  não precisa por \n   atalho: cw 

// dotnet run = executa
// CTRL + L = apaga o terminal

/*
namespace std;

    public class Program { 
        static void Main (string [] args) {
            Console.WriteLine("Olá mundo!");
            //enquanto o cin lia o tipo certo, o readline le somente string. 
            // string > variavel diferente
            //c++ = cin>>num1
            //resultado = alguma coisa

            //csharp = num1 = Convert.ToInt32 (Console.ReadLine)
        }                       ^ convere pra int 
    }

*/

using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.Arm;

namespace std;

    public class Program {
        static void Main (string [] args)
        {
            int num1,num2, subr, divr, multir;

            System.Console.WriteLine("\nInforme o primeiro número");
            num1=Convert.ToInt32(Console.ReadLine());

            // TUDO QUE VEM DA TELA (READLINE) É STRING, PRECISA CONVERTER!!

            System.Console.WriteLine("\nInforme o primeiro número");
            num2=Convert.ToInt32(Console.ReadLine());

            calculadora.Somar(num1,num2);

            calculadora.subr = Sub(num1,num2);
            System.Console.WriteLine("\n\tO resultado da subtração é: " + subr);

            calculadora.divr = Div(num1,num2);
            System.Console.WriteLine("\n\tO resultado da divisão é: " + divr);

            calculadora.multir = Multi(num1,num2);
            System.Console.WriteLine("\n\tO resultado da multiplicação é: " + multir);

            System.Console.WriteLine("\n");
    


            
        }
   
    // criar função aqui 
    // função foi pra calculadora, calculadora virou uma clase
    // adicionar calculadora na frente la na main. ex: calculadora.multir = Multi(num1,num2);
            //System.Console.WriteLine("\n\tO resultado da multiplicação é: " + multir);

   
    }



