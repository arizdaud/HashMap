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
    public class AccountManager : IAccountManager
    {

        #region Total Due Master

        public string SaveTotalDueMaster(TotalDueMaster saveTotalDueMaster)
        {
            string success = "";
            try
            {
                TotalDueMasterRepository db = new TotalDueMasterRepository();
                success = db.Save(saveTotalDueMaster);
            }
            catch (Exception ex)
            {

                success = "Total Due save UnSuccessfully";
                throw ex;

            }
            return success;
        }

        public IList<TotalDueMasterBusiness> GetAllTotalDueMaster()
        {
            IList<TotalDueMasterBusiness> totalDueMaster = new List<TotalDueMasterBusiness>();
            try
            {
                TotalDueMasterRepository ar = new TotalDueMasterRepository();
                DataSet ds = ar.GetList();
                if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null)
                {
                    totalDueMaster = DataBaseUtil.DataTableToList<TotalDueMasterBusiness>(ds.Tables[0]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return totalDueMaster;
        }

        #endregion

        #region Total Due Details

        public string SaveTotalDueDetails(TotalDueDetails saveTotalDueDetails)
        {
            string success = "";
            try
            {
                TotalDueDetailsRepository db = new TotalDueDetailsRepository();
                success = db.Save(saveTotalDueDetails);
            }
            catch (Exception ex)
            {

                success = "Total Due save UnSuccessfully";
                throw ex;

            }
            return success;
        }

        public IList<TotalDueDetailsBusiness> GetAllTotalDueDetails()
        {
            IList<TotalDueDetailsBusiness> totalDueDetails = new List<TotalDueDetailsBusiness>();
            try
            {
                TotalDueDetailsRepository ar = new TotalDueDetailsRepository();
                DataSet ds = ar.GetList();
                if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null)
                {
                    totalDueDetails = DataBaseUtil.DataTableToList<TotalDueDetailsBusiness>(ds.Tables[0]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return totalDueDetails;
        }

        #endregion

        #region Report

        public IList<SalesDetailsBusiness> GetAllSalesDetails(DateTime FromDate, DateTime ToDate)
        {
            IList<SalesDetailsBusiness> salesdetails = new List<SalesDetailsBusiness>();
            try
            {
                SalesDetailsRepository ar = new SalesDetailsRepository();
                salesdetails = ar.GetAllSalesDetailsReport(FromDate, ToDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return salesdetails;
        }

        public IList<PurchaseDetailsBusiness> GetAllPurchaseDetails(DateTime FromDate, DateTime ToDate)
        {
            IList<PurchaseDetailsBusiness> purchasedetails = new List<PurchaseDetailsBusiness>();
            try
            {
                PurchaseDetailsRepository ar = new PurchaseDetailsRepository();
                purchasedetails = ar.GetAllPurchaseDetailsReport(FromDate, ToDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return purchasedetails;
        }

        #endregion

        #region Payment Type

        public IList<PaymentType> GetAllPaymentType()
        {
            IList<PaymentType> lstPaymentType = new List<PaymentType>();
            try
            {
                PaymentTypeRepository db = new PaymentTypeRepository();
                DataSet dataSet = db.GetList();
                if (dataSet != null && dataSet.Tables != null && dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows != null)
                {
                    lstPaymentType = DataBaseUtil.DataTableToList<PaymentType>(dataSet.Tables[0]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstPaymentType;
        }

        #endregion

    }
}