namespace std;

public class Animal {
    protected string Name { get; set;}

    public Animal(string name) {
        Name = name;

    }
        public virtual void MakeSound() {
            Console.WriteLine("Emitindo um som.");
        }
}

public class Cat : Animal {

    public Cat(string name) : base(name) {}

    public override void MakeSound() {
        Console.WriteLine($"O gato {Name} está miando");
    }
}

public class Dog : Animal {
    public Dog(string name) : base(name) {}

    public override void MakeSound() {
        Console.WriteLine("O cachorro está latindo");

    }
    
}