using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG261_Project_2
{
    internal class Order:Program
    {
        public string orderName, orderNumber;

        public Order(string orderName, string orderNumber)
        {
            this.orderName = orderName;
            this.orderNumber = orderNumber;
        }

        public string OrderName { get; set; }
        public string OrderNumber { get; set; }

        public virtual string Orders()
        {
            return "";
        }
    }
}
