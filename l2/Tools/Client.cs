using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2.Tools
{
    internal class Client: Object
    {
        string name;
        string address;
        CreditCard card;
        BankAccount bankAccount;

        // Get and Set
        public string Name
        {
            get { return name; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public CreditCard Card
        {
            get { return card; }
            set { card = value; }
        }
        public BankAccount BankAccount
        {
            get { return bankAccount; }
            set {  bankAccount = value; }
        }

        public Client()
        {
            name = "Client";
            address = "Adress empty";
            card = null;
            bankAccount = null;
        }
        public Client(string name, string address, CreditCard creditCard = null, BankAccount bankAccount = null)
        {
            this.name = name;
            this.address = address;  
            this.card = creditCard;
            this.bankAccount = bankAccount;
        }

        /// <summary>
        /// 8 пункт
        /// </summary>
        public override string ToString()
        {
            return Convert.ToString(this.name);
        }

        // Method
        protected internal void blockCredirCard(Client client)
        {
            return;
        }

        protected internal void blockCredirCard()
        {
            this.Card.IsBlock = true;
        }


    }
}
