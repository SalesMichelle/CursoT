// Exercício 1: Criar e implementar uma interface básica
// Objetivo:
// Aprender a criar uma interface e fazer uma classe implementar seus métodos.

// Etapa 1: Criar a interface

public interface IFrontMottu

{
    public void ReceberClientes();
}

// Etapa 2: criar a classe

public class Funcionario : IFrontMottu
{
    public void ReceberClientes()
    {
    Console.WriteLine("Meu nome é João, trabalho na Mottu");
    }
}

// Inicializar de fato o programa

class Program
    {
    static void Main(string[] args)
        {
            IFrontMottu recepcaoCliente = new Funcionario();
            recepcaoCliente.ReceberClientes();

        }
    }