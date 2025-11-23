using Buy.Entities;

namespace Buy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine()!);
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine()!);
                Console.Write("Name: ");
                string name = Console.ReadLine()!;
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine()!);
                if (type == 'i')
                {
                    Console.Write("Customs fee: ");
                    double taxa = double.Parse(Console.ReadLine()!);
                    products.Add(new Importado(name, price, taxa));
                }
                else if (type == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime tempo_uso = DateTime.Parse(Console.ReadLine()!);
                    products.Add(new Usado(name, price, tempo_uso));
                }
                else
                {
                    products.Add(new Product(name, price));
                }
            }

            foreach (Product prod in products)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}