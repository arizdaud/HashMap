using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduWise.Framework;

namespace EduWise.Domain
{
    [Table("PaymentType")]
    public class PaymentType
    {
        [Identifier("PaymentTypeId")]
        public int PaymentTypeId { get; set; }
        public string PaymentTypeName { get; set; }
    }
}
