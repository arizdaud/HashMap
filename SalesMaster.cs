using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduWise.Framework;

namespace EduWise.Domain
{
    [Table("SalesMaster")]
    public class SalesMaster : BaseEntity
    {
        [Identifier("SalesMasterId")]
        public int SalesMasterId { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime Date { get; set; }
        public int CustomerId { get; set; }
        public int? ConsigneeId { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal SGST { get; set; }
        public decimal CGST { get; set; }
        public decimal IGST { get; set; }
        public decimal Freight { get; set; }
        public decimal Insurance { get; set; }
        public decimal PackingCharges { get; set; }
        public decimal NetAmount { get; set; }
        public string VehicleNo { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal AmountDue { get; set; }
        public decimal Debit { get; set; }
    }
}
