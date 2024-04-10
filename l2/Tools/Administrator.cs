using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2.Tools
{
    internal class Administrator: Client
    {
        private string name;


        public Administrator() {
            name = "Administrator";
        }
        public Administrator(string name) {
            this.name = name;
        }
        // 5
        protected internal new void blockCredirCard(Client client)
        {
            client.blockCredirCard();
        }
    }
}
    