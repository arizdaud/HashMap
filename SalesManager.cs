using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduWise.Domain;
using EduWise.DataLayer;
using EduWise.BusinessLayer.Interface;
using System.Data;


namespace EduWise.BusinessLayer
{
    public class SalesManager : ISalesManager
    {

        #region Sales Details

        public string SaveSalesDetails(IList<SalesDetails> lstSalesDetails)
        {
            string success = "";
            try
            {
                SalesDetailsRepository db = new SalesDetailsRepository();
                foreach (var item in lstSalesDetails)
                {
                    success = db.Save(item);

                }

            }
            catch (Exception ex)
            {

                success = "Sales Details save UnSuccessfully";
                throw ex;

            }
            return success;
        }

        public IList<SalesDetailsBusiness> GetAllSalesDetails()
        {
            IList<SalesDetailsBusiness> salesdetails = new List<SalesDetailsBusiness>();
            try
            {
                SalesDetailsRepository ar = new SalesDetailsRepository();
                DataSet ds = ar.GetList();
                if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null)
                {
                    salesdetails = DataBaseUtil.DataTableToList<SalesDetailsBusiness>(ds.Tables[0]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return salesdetails;
        }

        public string DeleteSalesDetails(int SalesDetailsId)
        {
            string success = "";
            try
            {
                SalesDetailsRepository db = new SalesDetailsRepository();
                db.Delete(SalesDetailsId);
                success = "Sales Details data delete Successfull";
            }
            catch (Exception ex)
            {
                success = "Sales Details data delete Unsuccessfull";
                throw ex;
            }
            return success;

        }

        #endregion

        #region Sales Master

        public string SaveSalesMaster(SalesMaster saveSalesMaster)
        {
            string success = "";
            try
            {
                SalesMasterRepository db = new SalesMasterRepository();
                success = db.Save(saveSalesMaster);

            }
            catch (Exception ex)
            {

                success = "Sales Master save UnSuccessfully";
                throw ex;

            }
            return success;
        }

        public IList<SalesMasterBusiness> GetAllSalesMaster()
        {
            IList<SalesMasterBusiness> salesMaster = new List<SalesMasterBusiness>();
            try
            {
                SalesMasterRepository ar = new SalesMasterRepository();
                DataSet ds = ar.GetList();
                if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null)
                {
                    salesMaster = DataBaseUtil.DataTableToList<SalesMasterBusiness>(ds.Tables[0]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return salesMaster;
        }

        public string UpdateSalesMaster(SalesMaster updateSalesMaster)
        {
            string success = "";
            try
            {
                SalesMasterRepository db = new SalesMasterRepository();
                db.Update(updateSalesMaster);
                success = "Sales Details data update Successfull";
            }
            catch (Exception ex)
            {
                success = "Sales Details data update Unsuccessfull";
                throw ex;
            }
            return success;
        }

        #endregion

        #region Bill

        public IList<GenerateBillBusiness> GetAllGenerateBill(int SalesDetailsId)
        {
            IList<GenerateBillBusiness> generateBill = new List<GenerateBillBusiness>();
            try
            {
                SalesDetailsRepository db = new SalesDetailsRepository();
                generateBill = db.GetGenerateBill(SalesDetailsId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return generateBill;
        }

        #endregion

    }
}
