using CadastroProdutos.Models;
using System.Collections.Generic;
using System.Linq;

namespace CadastroProdutos.Repositories
{
    public class ProdutoRepositoryInMemory : IProdutoRepository
    {
        private  readonly List<Produto> _produtos;  // Lista interna que vai armazenar os produtos.
        public ProdutoRepositoryInMemory()          //	Construtor da classe que inicializa a lista de produtos.
        {
            _produtos = new List<Produto>();        // Inicializando a lista.
        }

        public void Adicionar(Produto produto)      // Implementação do método Adicionar, que adiciona um produto à lista.
        {
            _produtos.Add(produto);             // Adicionando o produto à lista.
        }

        public IEnumerable<Produto> ListarTodos()       // Implementação do método ListarTodos, que retorna todos os produtos armazenados.
        {
            return _produtos;                   // Retornando todos os produtos armazenados.
        }
    }
}