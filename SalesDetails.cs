using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduWise.Framework;

namespace EduWise.Domain
{
    [Table("SalesDetails")]
    public class SalesDetails : BaseEntity
    {
        [Identifier("SalesDetailsId")]
        public int SalesDetailsId { get; set; }
        public int SalesMasterId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int UnitId { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
    }
}
