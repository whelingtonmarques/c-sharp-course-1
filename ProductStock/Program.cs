using System;
using System.Globalization;

namespace ProductStock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produdo:");

            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Preço: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantity = int.Parse(Console.ReadLine());

            Product product = new Product(name, price, quantity);

            product.TotalValue();

            Console.WriteLine(product);

            Console.Write("Quantidade de produtos a serem adicionados ao estoque: ");
            int add = int.Parse(Console.ReadLine());

            product.AddProduct(add);

            Console.WriteLine(product);

            Console.Write("Quantidade de produtos a serem removidos do estoque: ");
            int remove = int.Parse(Console.ReadLine());

            product.RemoveProduct(remove);

            Console.WriteLine(product);
        }
    }
}
