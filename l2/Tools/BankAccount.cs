using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2.Tools
{
    internal class BankAccount // Рахунок
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private List<Order> orders;

        internal List<Order> Orders
        {
            get { return orders; }
        }

        internal BankAccount()
        {
            orders = new List<Order>();
        }

        internal BankAccount(List<Order> orders, string name)
        {
            this.orders = orders;
            this.name = name;
        }
        internal BankAccount(string name)
        {
            orders = new List<Order>();
            this.name = name;
        }
        internal void CreateNewOrder(Order order)
        {
            orders.Add(order);
        }
        public override string ToString()
        {
            return name;
        }

    }
}
