namespace std;   // abstração de classe , model e repository é pra ser a msm coisa, controller acessa os dois

public class Pessoa : Usuario {
    //atributos - nome e idade
    public string Nome { get; set; }
    public int Idade { get; set; }

    // para não permitir criação de objetos vazios (null), preciso modificar o construtor da classe

    public Pessoa(string nome, int idade,string email) : base(email) 
    {
       //Pessoa = construtor    //email mudar no usuario pq herdou de lá
        Nome = nome;
        Idade = idade;
        RepositoryPessoa.AdicionarPessoa(this);   //this = contexto do constutor, referenciando a pessoa 
    }     

    //metodos - comer e mostrar dados
    public void Comer(){
        System.Console.WriteLine($"{Nome} está comendo neste momento, aguarde um minuto");
    }

    // override ToString()
    public void MostrarDados() {
        System.Console.WriteLine($"\n\tNome: {Nome}, Idade: {Idade}, Email: {Email}");

    }

}