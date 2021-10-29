using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduWise.Framework;

namespace EduWise.Domain
{
    [Table("TotalDueDetails")]
    public class TotalDueDetails : BaseEntity
    {
        [Identifier("TotalDueMasterId")]
        public int TotalDueDetailsId { get; set; }
        public DateTime Date { get; set; }
        public int CustomerId { get; set; }
        public decimal AmountPaid { get; set; }

    }
}
