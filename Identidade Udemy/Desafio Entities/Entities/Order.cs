using Desafio_Entities.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Entities.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(params OrderItem[] item)
        {
            foreach (OrderItem Item in item)
            {
                Items.Add(Item);
            }
        }
        public void RemoveItem(params OrderItem[] item)
        {
            foreach (OrderItem Item in Items)
            {
                Items.Remove(Item);
            }
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem Item in Items)
            {
                sum += Item.SubTotal();
            }
            return sum;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine("Order Moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client.Name + " " + Client.BirthDay + " - " + Client.Email);
            sb.AppendLine("Order items: ");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine($"Total Price ${Total()}");

            return sb.ToString();






        }
    }
}
