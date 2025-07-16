using System.Globalization;
using System;
using classes;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Entre com os dados do produto");
            Console.WriteLine("Nome");
            produto.Nome = Console.ReadLine();

            Console.WriteLine("Preço");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantidade no estoque");
            produto.Quantidade = int.Parse(Console.ReadLine());


            Console.WriteLine("Dados do produto: " + produto.ToString());


            Console.WriteLine("Digite o número de produtos a serem adicionados ao estoque");
            int quantidadeAdicionar = int.Parse(Console.ReadLine());
            produto.AdicionarEstoque(quantidadeAdicionar);

            Console.WriteLine("Dados atualizados: " + produto.ToString());

            Console.WriteLine("Digite o número de produtos a serem removidos do estoque");
            int quantidadeRemover = int.Parse(Console.ReadLine());
            produto.RemoverEstoque(quantidadeRemover);

            Console.WriteLine("Dados atualizados: " + produto.ToString());

            Console.ReadLine();
        }
    }
}