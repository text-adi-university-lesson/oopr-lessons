using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace l2.Tools
{   

    internal class CreditCard
    {
        private bool isBlock;
        private string number;
        private decimal balance;


        internal string Number
        {
            get { return number; }
        }

        internal bool IsBlock {
            get { return isBlock; }
            set { isBlock = value; }
        }

        internal decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        internal CreditCard()
        {
            isBlock = false;
            number = null;
            balance = 0;
        }
        internal CreditCard(string number)
        {
            this.number = number;
            isBlock = false;
            balance = 0;
        }

        internal CreditCard(string number, decimal balance = 0, bool isBlock=false)
        {
            this.number = number;
            this.balance = balance;
            this.isBlock = isBlock;
        }



        /// <summary>
        /// Операція з картою, Поповнення та виведення коштів, з терміналу
        /// </summary>
        /// <param name="money"></param>
        internal void makeOperation(decimal money)
        {
            balance += money;
        }


        public override string ToString()
        {
            return number;
        }

    }
}
