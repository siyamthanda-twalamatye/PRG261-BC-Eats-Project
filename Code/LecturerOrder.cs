using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG261_Project_2
{
    internal class LecturerOrder : Order
    {
        public string lectInvoice;

        public LecturerOrder(string orderName, string orderNumber, string lectInvoice) : base(orderName, orderNumber)
        {
            this.lectInvoice = lectInvoice;
        }

        public override string Orders()
        {
            return "Order Name: " + orderName + " |Order Number: " + orderNumber + " |Invoice provided?: " + lectInvoice;
        }
    }
}
