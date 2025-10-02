using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG261_Project_2
{
    internal class studentOrder : Order
    {
        public string studInvoice;

        public studentOrder(string orderName, string orderNumber, string studInvoice) :base(orderName, orderNumber)
        {
            this.studInvoice = studInvoice;
        }

        public override string Orders()
        {
            return "Order Name:" + orderName + "| Order Number:" + orderNumber + "| Student Invoice:" + studInvoice;   
        }
    }
}
