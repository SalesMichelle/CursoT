abstract class RecipienteTermico
{
    public string Nome { get; set; }

    public abstract void Encher(); // Método sem corpo → deve ser implementado nas subclasses

    public void Apresentar() // Método normal
    {
        Console.WriteLine($"{Nome};");
    }
}

class GarrafaTermica : RecipienteTermico
{
    public override void Encher()
    {
        Console.WriteLine("Volume de 1000 mL");
    }
}

class CopoTermico : RecipienteTermico
{
    public override void Encher()
    {
        Console.WriteLine("Volume de 600 mL");
    }
}
class Program
{
    static void Main()
    {
        RecipienteTermico garrafaTermica = new GarrafaTermica {Nome = "Garrafa Gocase"};
        RecipienteTermico copoTermico = new CopoTermico {Nome = "Copo Stanley"};

        garrafaTermica.Apresentar();
        garrafaTermica.Encher();

        copoTermico.Apresentar();
        copoTermico.Encher();
    }
}