using System.Globalization;

namespace ProductStock
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; private set; }
        public int Quantity { get; private set; }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double TotalValue()
        {
            return Price * Quantity;
        }

        public void AddProduct(int quantity)
        {
            Quantity += quantity;
        }
        public void RemoveProduct(int quantity)
        {
            Quantity -= quantity;
        }

        public override string ToString()
        {
            return "Dados atualizados: " + Name + ", $ " + Price.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantity + " unidades, Total: $ " + TotalValue().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
