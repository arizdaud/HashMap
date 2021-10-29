using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduWise.Framework;

namespace EduWise.Domain
{
    [Table("Days")]
    public class Days : BaseEntity
    {
        [Identifier("DaysId")]
        public int DaysId { get; set; }
        public string DaysName { get; set; }
    }
}
