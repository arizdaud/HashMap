using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduWise.Framework;


namespace EduWise.Domain

{
    [Table("Product")]
    public class Product : BaseEntity
    {
        [Identifier("ProductId")]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int HSN { get; set; }
    }
}
