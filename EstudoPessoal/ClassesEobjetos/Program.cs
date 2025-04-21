// Exercício: Criar uma classe Pessoa: Criar uma classe chamada Pessoa
//Adicionar dois atributos: nome (string) e idade (int)
// Criar um objeto dessa classe no Main
// Atribuir valores ao objeto e imprimir no console

// Novo desafio: Pedir para o usuário digitar o nome e a idade
using System ;
using System.Diagnostics; // Importa a biblioteca padrão

class Pessoa // Inicializar a classe Pessoa
{
    public string nome = "";// o public é usado para que esse atributo seja acessado fora dessa classe.
    public int idade = 0 ;

    public void MostrarDados() // void significa que o método não retorna valor, apenas executa uma ação.
    {
        Console.WriteLine("Nome: " + nome) ; // Imprime o nome
        Console.WriteLine("Idade: " + idade); // Imprime a idade
    }
}

class Program // Classe principal - é onde o programa começa de fato a rodar, para executar precisa estar dentro do Main, e o Main está dentro do Program.
{
    static void Main(string[] args) // Um vetor de strings com argumentos que podem ser passados ao executar o programa pelo terminal (mas você pode ignorar isso por enquanto).
    {
        Pessoa p1 = new Pessoa(); // cp1 é um objeto da classe Pessoa, está criando um novo objeto (instância) baseado na classe.
        
        Console.WriteLine("Digite o nome:"); // Usuário digita o nome
        p1.nome = Console.ReadLine() ; // Console.Readline não recebe nenhum argumento, os partêntesis devem estar vazios.

        Console.WriteLine("Digite a idade");
        p1.idade = int.Parse(Console.ReadLine());

        p1.MostrarDados(); // Chama o método MostrarDados para exibir as informações no console
    }
}   