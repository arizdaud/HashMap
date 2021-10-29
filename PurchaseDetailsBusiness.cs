using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduWise.Domain
{
    public class PurchaseDetailsBusiness : PurchaseDetails
    {
        public DateTime InvoiceDate { get; set; }
        public string InvoiceNo { get; set; }
        public string Name { get; set; }
        public string ProductName { get; set; }
        public decimal TotalAmount { get; set; }
        public string UnitName { get; set; }
        public decimal NetAmount { get; set; }
        public string PaymentTypeName { get; set; }
    }
}