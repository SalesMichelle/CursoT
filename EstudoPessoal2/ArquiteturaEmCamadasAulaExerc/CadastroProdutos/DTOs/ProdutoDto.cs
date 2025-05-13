namespace CadastroProdutos.DTOs
{
    public class ProdutoDto
    {
        public string Nome { get; set; }      // Nome que será enviado ou recebido pela API. Pode ser lido e modificado.
        public decimal Preco { get; set; }     // Preço do produto, também acessível para leitura e modificação.

        public ProdutoDto(string nome, decimal preco)       // Construtor que obriga o preenchimento de Nome e Preco na criação.
        {
            Nome = nome;
            Preco = preco;
        }
    }
}