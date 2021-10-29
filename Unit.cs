using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduWise.Framework;

namespace EduWise.Domain
{
    [Table("Unit")]
    public class Unit : BaseEntity
    {
        [Identifier("UnitId")]
        public int UnitId { get; set; }
        public string UnitName { get; set; }
    }
}
