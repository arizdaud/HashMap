using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduWise.Framework;

namespace EduWise.Domain
{
    [Table("State")]
    public class State
    {
        [Identifier("StateId")]
        public int StateId { get; set; }
        public string StateName { get; set; }
    }
}
