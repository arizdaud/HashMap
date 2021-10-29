using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduWise.Domain
{
    public class TotalDueMasterBusiness : TotalDueMaster
    {
        public string Name { get; set; }
        public decimal Debit { get; set; }
    }
}
