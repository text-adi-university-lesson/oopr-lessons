using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2.Tools
{
    internal class Order
    {
        string name;
        decimal price;
        string description;


        public string Name
        {
            get { return name; }
        }
        public decimal Price
        {
            get { return price; }
        }
        public string Description
        {
            get { return description; }
        }


        internal Order()
        {
            name = "Order empty";
            description = "";
            price = 0;
        }
        internal Order(string name, decimal price = 0, string description = null)
        {
            this.name = name;
            this.price = price;
            this.description = description;
        }

    }
}
