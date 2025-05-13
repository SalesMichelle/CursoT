using CadastroProdutos.Models;

namespace CadastroProdutos.Repositories
{
    public interface IProdutoRepository
    {
        void Adicionar(Produto produto);      // Método para adicionar um novo produto
        IEnumerable<Produto> ListarTodos();   // Método que deve retornar uma lista de todos os produtos,  permite que os dados sejam iterados de forma eficiente.

    }
}