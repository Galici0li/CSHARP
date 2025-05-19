namespace std;

public class Pessoa : Usuario {
    //atributos - nome e idade
    public string Nome { get; set; }
    public int Idade { get; set; }

    //metodos - comer e mostrar dados
    public void Comer(){
        System.Console.WriteLine($"{Nome} está comendo neste momento, aguarde um minuto");
    }

    // override ToString()
    public void MostrarDados() {
        System.Console.WriteLine($"\n\tNome: {Nome}, Idade: {Idade}, Email: {Email}");

    }

}