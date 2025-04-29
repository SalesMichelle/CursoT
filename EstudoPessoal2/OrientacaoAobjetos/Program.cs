

class Animal
{
    public virtual void Falar()
    {
        Console.WriteLine("Método padrão da classe Animal");
    }
}

// Class dervidada

class Cachorro : Animal
{
    public override void Falar()
    {
        Console.WriteLine("O cahorro faz Au Au");
    }
}

class Gato : Animal
{
    public override void Falar()
    {
        Console.WriteLine("O gato faz miau!");
    }
}

// Uso no programa

class Program
{
    static void Main()
    {
        Animal cachorro = new Cachorro();
        cachorro.Falar() ; // Saída desse comportamento

        Animal gato = new Gato();
        gato.Falar() ; // Saída desse comportamento
    }
}

