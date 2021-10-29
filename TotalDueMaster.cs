using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduWise.Framework;

namespace EduWise.Domain
{
    [Table("TotalDueMaster")]
    public class TotalDueMaster : BaseEntity
    {
        [Identifier("TotalDueMasterId")]
        public int TotalDueMasterId { get; set; }
        public DateTime Date { get; set; }
        public string InvoiceNo { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalNetAmount { get; set; }
        public decimal TotalAmountPaid { get; set; }
        public decimal TotalAmountDue { get; set; }

    }
}
