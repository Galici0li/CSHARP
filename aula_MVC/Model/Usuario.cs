namespace std;

public class Usuario {

        //atributo - email
    public string Email { get; set; }

        //metodos - login 
    public void Login() {
        System.Console.WriteLine($"{Email} está entrando no sistema");

    }
    
}