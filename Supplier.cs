using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduWise.Framework;

namespace EduWise.Domain

{
    [Table("Supplier")]
    public class Supplier : BaseEntity
    {
        [Identifier("SupplierId")]
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public string StateName { get; set; }
        public string GSTIN { get; set; }

    }
}
