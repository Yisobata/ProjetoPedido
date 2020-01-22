using System;
using SystemOrder.Entities;
using SystemOrder.Entities.Enums;

namespace SystemOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            DateTime moment = DateTime.Now;
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            Order order = new Order(moment, status, client);

            for (int i = 1; i<=n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(productName, price);
                OrderItem orderItem = new OrderItem(quantity, price, product);
                order.AddItem(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order);
        }
    }
}
