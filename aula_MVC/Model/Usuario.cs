namespace std;

public class Usuario {

        //atributo - email
    public string Email { get; set; }

    public Usuario(string email)
    {
        Email = email;
    }

        //metodos - login 
    public void Login() {
        System.Console.WriteLine($"{Email} está entrando no sistema");

    }
    
}