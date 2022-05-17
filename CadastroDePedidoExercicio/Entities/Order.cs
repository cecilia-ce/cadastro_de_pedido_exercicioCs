using CadastroDePedidoExercicio.Enums;
using System.Collections.Generic;
using System;
using System.Text;

namespace CadastroDePedidoExercicio.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }

        public List<OrderItem> OrderItems = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            OrderItems.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            OrderItems.Add(item);
        }

        public double Total()
        {
            double soma = 0;
            foreach(OrderItem item in OrderItems)
            {
                soma += item.SubTotal();
            }
            return soma;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.AppendLine(Client.ToString());
            sb.AppendLine("Order Items:");
            foreach(OrderItem item in OrderItems)
            {
                sb.AppendLine(item.ToString());
            }
            sb.Append("Total price: $");
            sb.Append(Total());
            return sb.ToString();
        }






    }
}
