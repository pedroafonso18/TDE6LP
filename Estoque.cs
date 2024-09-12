class Estoque{
    public string produto;
    public int quantidade;
    public double preco;

    public void AdicionarAoEstoque(int quantidadeProdutos)
    {
        quantidade += quantidadeProdutos;
    }

    public void RemoverDoEstoque(int quantidadeProdutos)
    {
        quantidade -= quantidadeProdutos;
    }

    public double RetornaValorTotalEstoque()
    {
        return preco * quantidade;
    }

    public void ExibeInformacoes()
    {
        Console.WriteLine($"O nome é {produto}, a quantidade em estoque é {quantidade}, e o preço do produto é {preco}");
    }
}