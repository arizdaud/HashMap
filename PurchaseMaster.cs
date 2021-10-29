using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduWise.Framework;

namespace EduWise.Domain
{
    [Table("PurchaseMaster")]
    public class PurchaseMaster : BaseEntity
    {
        [Identifier("PurchaseMasterId")]
        public int PurchaseMasterId { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int SupplierId { get; set; }
        public int PaymentTypeId { get; set; }
        public string PaymentDescription { get; set; }
        public decimal Total { get; set; }
        public decimal Discount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal GST { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal NetAmount { get; set; }

    }
}
