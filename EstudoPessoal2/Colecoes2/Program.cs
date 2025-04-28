// Você tem uma pilha de livros. A pilha é uma estrutura de dados onde o último livro colocado é o primeiro a ser retirado (LIFO - Last In, First Out).
// Crie uma Stack (pilha) para armazenar nomes de livros.
// Peça ao usuário para digitar 5 nomes de livros e adicione-os à pilha.
// Após isso, mostre todos os livros armazenados na pilha, retirando-os um a um (usando o método Pop()), e exibindo cada um no console.

using System;
using System.Collections.Generic;

// Definição da classe Livro
class Livro
{
    // Propriedades do livro: Titulo e AnoPublicacao
    public string Titulo { get; set; }
    public int AnoPublicacao { get; set; }

    // Construtor para inicializar um livro com título e ano de publicação
    public Livro(string titulo, int anoPublicacao)
    {
        Titulo = titulo;
        AnoPublicacao = anoPublicacao;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criação de uma pilha (Stack) de objetos do tipo Livro
        Stack<Livro> pilhaLivros = new Stack<Livro>();

        // Inserção de 5 livros na pilha
        for (int i = 0; i < 5; i++)  // Loop para pedir 5 livros ao usuário
        {
            // Solicita o título do livro
            Console.WriteLine("Digite o título do livro:");
            string titulo = Console.ReadLine();  // Lê o título do livro digitado

            // Solicita o ano de publicação do livro
            Console.WriteLine("Digite o ano de publicação do livro:");
            int anoPublicacao = int.Parse(Console.ReadLine());  // Lê e converte o ano digitado

            // Criação de um objeto Livro com as informações fornecidas pelo usuário
            Livro livro = new Livro(titulo, anoPublicacao);

            // Adiciona o livro à pilha (Stack)
            pilhaLivros.Push(livro);
        }

        // Exibe os livros armazenados na pilha (antes da remoção)
        Console.WriteLine("\nLivros na pilha:");
        foreach (var livro in pilhaLivros)  // Percorre a pilha e exibe os livros
        {
            Console.WriteLine($"{livro.Titulo} - {livro.AnoPublicacao}");
        }

        // Loop para retirar livros da pilha, enquanto houver livros na pilha
        while (pilhaLivros.Count > 0)  // Verifica se ainda há livros na pilha
        {
            // Pergunta ao usuário se deseja retirar o livro mais recente
            Console.WriteLine("\nDeseja retirar o livro mais recente? (s/n):");
            string resposta = Console.ReadLine().ToLower();  // Lê a resposta do usuário e converte para minúsculo

            if (resposta == "s")  // Se a resposta for 's' (sim)
            {
                // Retira o livro mais recente (último colocado) da pilha
                Livro livroRetirado = pilhaLivros.Pop();

                // Exibe o livro retirado
                Console.WriteLine($"Livro retirado: {livroRetirado.Titulo} - {livroRetirado.AnoPublicacao}");
            }
            else  // Caso a resposta seja diferente de 's'
            {
                break;  // Encerra o loop caso o usuário não queira mais retirar livros
            }

            // Exibe os livros restantes na pilha após a remoção
            Console.WriteLine("\nLivros restantes na pilha:");
            foreach (var livro in pilhaLivros)  // Exibe a pilha atualizada após cada remoção
            {
                Console.WriteLine($"{livro.Titulo} - {livro.AnoPublicacao}");
            }
        }

        // Exibe uma mensagem quando o programa terminar
        Console.WriteLine("\nPrograma encerrado.");
    }
}
