using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduWise.Domain
{
   public class SalesDetailsBusiness :SalesDetails
    {
        public string ProductName { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string UnitName { get; set; }
        public decimal NetAmount { get; set; }
        public string InvoiceNo { get; set; }
        public decimal AmountDue { get; set; }
        public decimal Debit { get; set; }
    }
}
