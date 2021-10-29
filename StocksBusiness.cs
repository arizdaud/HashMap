using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduWise.Domain
{
    public class StocksBusiness : Stocks
    {
        public string ProductName { get; set; }
        public string UnitName { get; set; }
    }
}