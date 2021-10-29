using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduWise.Domain
{
    public class PurchaseMasterBusinesss : PurchaseMaster
    {
        public string Name { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public int Waste { get; set; }
        public int ValuableQuantity { get; set; }
        public string UnitName { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public string PaymentTypeName { get; set; }
    }
}
