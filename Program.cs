Estoque e1 = new Estoque();


Console.WriteLine("Informe o nome do produto para adicionar ao estoque: ");
e1.produto = Console.ReadLine();
Console.WriteLine("Informe a quantidade do produto que temos em estoque: ");
int quantidade = Convert.ToInt32(Console.ReadLine());
e1.AdicionarAoEstoque(quantidade);
Console.WriteLine("Informe o preço do produto em estoque: ");
e1.preco = Convert.ToDouble(Console.ReadLine());

e1.ExibeInformacoes();