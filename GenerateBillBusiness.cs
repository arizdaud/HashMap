using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduWise.Domain
{
    public class GenerateBillBusiness : SalesDetails
    {
        public string InvoiceNo { get; set; }
        public DateTime Date { get; set; }
        public string CusName { get; set; }
        public string CusAddress { get; set; }
        public string CusStateName { get; set; }
        public string CusGSTIN { get; set; }
        public string ConName { get; set; }
        public string ConAddress { get; set; }
        public string ConStateName { get; set; }
        public string ConGSTIN { get; set; }
        public string ProductName { get; set; }
        public int HSN { get; set; }
        public string UnitName { get; set; }
        public decimal SGST { get; set; }
        public decimal CGST { get; set; }
        public decimal IGST { get; set; }
        public decimal Freight { get; set; }
        public decimal Insurance { get; set; }
        public decimal PackingCharges { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal NetAmount { get; set; }
        public string VehicleNo { get; set; }
    }
}
