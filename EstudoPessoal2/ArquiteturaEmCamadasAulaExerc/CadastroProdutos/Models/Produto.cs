using System;

namespace CadastroProdutos.Models
{
    public class Produto
    {
        public Guid Id {get; private set;} // Guid evita que um Id se repita 
        // get; private set;: qualquer parte do código pode ler (get) o valor do ID, mas apenas a própria classe pode definir/modificar (set) esse valor.

        public string Nome { get; private set; }
        public decimal Preco { get; private set; }

        public Produto(string nome, decimal preco)  //  construtor da classe. Ele obriga que um nome e um preço sejam passados quando um produto for criado.
        {
            Id = Guid.NewGuid(); // Gera ID automaticamente
            Nome = nome;
            Preco = preco;

        }

    }
}