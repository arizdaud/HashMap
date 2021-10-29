using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using EduWise.Domain;

namespace EduWise.DataLayer
{
    public class PurchaseDetailsRepository : BaseRepository<PurchaseDetails>
    {

        public IList<PurchaseDetailsBusiness> GetStocksPurchaseDetails()
        {
            PurchaseDetailsBusiness PurchaseDetailsBuisness = null;
            IList<PurchaseDetailsBusiness> lstPurchaseDetails = null;
            try
            {
                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database _db = factory.Create("DefConn");
                DbCommand sqlCommand = _db.GetStoredProcCommand("ListStocksPurchase");
                DataSet dataSet = new DataSet();

                _db.LoadDataSet(sqlCommand, dataSet, TableName);

                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    DataTable dt = dataSet.Tables[0];
                    lstPurchaseDetails = new List<PurchaseDetailsBusiness>();
                    foreach (DataRow dr in dt.Rows)
                    {
                        PurchaseDetailsBuisness = new PurchaseDetailsBusiness();
                        PurchaseDetailsBuisness.ProductName = Convert.ToString(dr["Product"]);
                        PurchaseDetailsBuisness.UnitName = Convert.ToString(dr["Unit"]);
                        PurchaseDetailsBuisness.Quantity = Convert.ToInt32(dr["Quantity"]);
                        lstPurchaseDetails.Add(PurchaseDetailsBuisness);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstPurchaseDetails;
        }

        public IList<PurchaseDetailsBusiness> GetAllPurchaseDetailsReport(DateTime FromDate, DateTime ToDate)
        {
            PurchaseDetailsBusiness purchaseDetailsBusiness = null;
            IList<PurchaseDetailsBusiness> LstPurchaseDetailsBusiness = null;
            try
            {
                DatabaseProviderFactory factory = new DatabaseProviderFactory();
                Database _db = factory.Create("DefConn");
                DbCommand sqlCommand = _db.GetStoredProcCommand("ListPurchaseReport");
                DataSet dataSet = new DataSet();

                var DateFrom = sqlCommand.CreateParameter();
                DateFrom.ParameterName = "FromDate";
                DateFrom.Value = FromDate;
                sqlCommand.Parameters.Add(DateFrom);

                var DateTo = sqlCommand.CreateParameter();
                DateTo.ParameterName = "ToDate";
                DateTo.Value = ToDate;
                sqlCommand.Parameters.Add(DateTo);


                _db.LoadDataSet(sqlCommand, dataSet, TableName);

                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    DataTable dt = dataSet.Tables[0];
                    LstPurchaseDetailsBusiness = new List<PurchaseDetailsBusiness>();
                    foreach (DataRow dr in dt.Rows)
                    {
                        purchaseDetailsBusiness = new PurchaseDetailsBusiness();
                        purchaseDetailsBusiness.InvoiceDate = Convert.ToDateTime(dr["InvoiceDate"]);
                        purchaseDetailsBusiness.InvoiceNo = Convert.ToString(dr["InvoiceNo"]);
                        purchaseDetailsBusiness.Name = Convert.ToString(dr["Name"]);
                        purchaseDetailsBusiness.NetAmount = Convert.ToDecimal(dr["NetAmount"]);
                        LstPurchaseDetailsBusiness.Add(purchaseDetailsBusiness);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return LstPurchaseDetailsBusiness;
        }

    }
}
