// Você tem uma pilha de livros. A pilha é uma estrutura de dados onde o último livro colocado é o primeiro a ser retirado (LIFO - Last In, First Out).
// Crie uma Stack (pilha) para armazenar nomes de livros.
// Peça ao usuário para digitar 5 nomes de livros e adicione-os à pilha.
// Após isso, mostre todos os livros armazenados na pilha, retirando-os um a um (usando o método Pop()), e exibindo cada um no console.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Stack<string> pilha = new Stack<string>();

        for(int i = 0 ; i < 5 ; i ++ )
        {
            Console.WriteLine("Digite os livros em sequência");
            string livro = Console.ReadLine(); // Lê o livro
            pilha.Push(livro); // Adiciona à lista
        }
        
        // Mostrando os livros da pilha, retirando um a um
        Console.WriteLine("Livros armazenados na pilha (ordem inversa): ");
        
        while(pilha.Count > 0)
        {
             Console.WriteLine(pilha.Pop()); // Retira e mostra o livro do topo da pilha.
        }
    
    }
}