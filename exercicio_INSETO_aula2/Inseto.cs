namespace std;

public class Inseto {
    public string Color { get; set; }

    public Inseto(string cor) {
        Color = cor;
    }
        public virtual void ApresentarInsito() {
            Console.WriteLine("Quantidade de patas");
        }  
} 

public class Aranha : Inseto {
    int Patas { get; set; }
    public Aranha(string cor, int patas) : base(cor) {
        Patas = patas;
    }

    public override void ApresentarInsito() {
        System.Console.WriteLine($"A aranha é da cor {Color} e tem {Patas} patas");
    }

}

public class Formiga : Inseto {
    public Formiga(string cor) : base(cor) {}

    public override void ApresentarInsito() {
        System.Console.WriteLine($"A formiga é da cor {Color} e tem 6 patas");
     
    }
}