using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2.Tools
{
    // 7
    internal sealed class Payment
    {
        List<Client> clients;
        List<BankAccount> bankAccounts;
        List<CreditCard> creditCards;
        List<Order> orders;


        internal List <Client> Clients
        {
            get { return clients; }
            set { clients = value; }
        }

        internal List<BankAccount> BankAccounts
        {
            get { return bankAccounts; }
            set { bankAccounts = value; }
        }

        internal List<CreditCard> CreditCards
        {
            get { return creditCards; }
            set { creditCards = value; }
        }
        internal List<Order> Orders
        {
            get { return orders; }
            set { orders = value; }
        }


        internal Payment()
        {
            clients = new List<Client>();
            this.bankAccounts = new List<BankAccount>(); ;
            this.creditCards = new List<CreditCard>(); ;
            this.orders = new List<Order>(); ;
        }
        internal Payment(List<Client> clients, List<BankAccount> bankAccounts, List<CreditCard> creditCards, List<Order> orders)
        {
            this.clients = clients;
            this.bankAccounts = bankAccounts;
            this.creditCards = creditCards;
            this.orders = orders;
        }
        public sealed override string ToString()
        {
            return "Sealed class method";
        }
    }
}
