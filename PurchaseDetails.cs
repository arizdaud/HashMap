using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduWise.Framework;
using EduWise.Domain;

namespace EduWise.Domain
{
    [Table("PurchaseDetails")]
    public class PurchaseDetails : BaseEntity
    {
        [Identifier("PurchaseDetailsId")]
        public int PurchaseDetailsId { get; set; }
        public int PurchaseMasterId { get; set; }
        public int ProductId { get; set; }
        public int UnitId { get; set; }
        public int Quantity { get; set; }
        public int Waste { get; set; }
        public int ValuableQuantity { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
    }
}
