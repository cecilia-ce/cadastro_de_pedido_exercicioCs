using System;
using CadastroDePedidoExercicio.Enums;
using CadastroDePedidoExercicio.Entities;
using System.Globalization;


namespace CadastroDePedidoExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");

            Console.Write("Name:");
            string name = Console.ReadLine();

            Console.Write("E-mail:");
            string email = Console.ReadLine();

            Console.Write("Birth date (dd/MM/yyyy):");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client c = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data:");

            Console.Write("Status (Pending_payment / Processing / Shipped / Delivered):");
            OrderStatus order_status = Enum.Parse<OrderStatus>(Console.ReadLine());

            DateTime moment = DateTime.Now;

            Order order = new Order(moment, order_status, c);

            Console.Write("How many items to this order? ");
            int numberOfItems = int.Parse(Console.ReadLine());
  
            for(int i = 1; i <= numberOfItems; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine(); 
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem order_item = new OrderItem(product, quantity, productPrice);
                order.AddItem(order_item);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("ORDER SUMARY:");
            Console.WriteLine(order);

           



        }
    }
}
