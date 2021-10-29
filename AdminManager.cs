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
    public class AdminManager : IAdminManager
    {

        #region Customer

        public string SaveCustomer(Customer saveCustomer)
        {
            string success = "";
            try
            {
                CustomerRepository db = new CustomerRepository();
                success = db.Save(saveCustomer);
            }
            catch (Exception ex)
            {

                success = "Customer save UnSuccessfull !";
                throw ex;

            }
            return success;
        }

        public IList<CustomerBusiness> GetAllCustomer()
        {
            IList<CustomerBusiness> customer = new List<CustomerBusiness>();
            try
            {
                CustomerRepository ar = new CustomerRepository();
                DataSet ds = ar.GetList();
                if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null)
                {
                    customer = DataBaseUtil.DataTableToList<CustomerBusiness>(ds.Tables[0]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return customer;
        }

        public string UpdateCustomer(Customer updateCustomer)
        {
            string success = "";
            try
            {
                CustomerRepository db = new CustomerRepository();
                db.Update(updateCustomer);
                success = "Customer Update Successfull !";
            }
            catch (Exception ex)
            {
                success = "Customer Update not Successfull !";
                throw ex;
            }
            return success;
        }

        public string DeleteCustomer(int CustomerId)
        {
            string success = "";
            try
            {
                CustomerRepository db = new CustomerRepository();
                db.Delete(CustomerId);
                success = "Customer Delete Successfull !";
            }
            catch (Exception ex)
            {
                success = "Customer Delete Unsuccessfull !";
                throw ex;
            }
            return success;

        }

        #endregion

        #region Consignee

        public string SaveConsignee(Consignee saveConsignee)
        {
            string success = "";
            try
            {
                ConsigneeRepository db = new ConsigneeRepository();
                success = db.Save(saveConsignee);
            }
            catch (Exception ex)
            {

                success = "Consignee save UnSuccessfully";
                throw ex;

            }
            return success;
        }

        public IList<Consignee> GetAllConsignee()
        {
            IList<Consignee> consignee = new List<Consignee>();
            try
            {
                ConsigneeRepository ar = new ConsigneeRepository();
                DataSet ds = ar.GetList();
                if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null)
                {
                    consignee = DataBaseUtil.DataTableToList<Consignee>(ds.Tables[0]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return consignee;
        }

        #endregion

        #region Supplier

        public string SaveSupplier(Supplier saveSupplier)
        {
            string success = "";
            try
            {
                SupplierRepository db = new SupplierRepository();
                success = db.Save(saveSupplier);
            }
            catch (Exception ex)
            {
                success = "Supplier save UnSuccessfull !";
                throw ex;
            }
            return success;
        }

        public IList<SupplierBusiness> GetAllSupplier()
        {
            IList<SupplierBusiness> class1 = new List<SupplierBusiness>();
            try
            {
                SupplierRepository ar = new SupplierRepository();
                DataSet ds = ar.GetList();
                if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null)
                {
                    class1 = DataBaseUtil.DataTableToList<SupplierBusiness>(ds.Tables[0]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return class1;
        }

        public string UpdateSupplier(Supplier updateSupplier)
        {
            string success = "";
            try
            {
                SupplierRepository db = new SupplierRepository();
                db.Update(updateSupplier);
                success = "Supplier Update Successfull !";
            }
            catch (Exception ex)
            {
                success = "Supplier Update Unsuccessfull !";
                throw ex;
            }
            return success;
        }

        public string DeleteSupplier(int SupplierId)
        {
            string success = "";
            try
            {
                SupplierRepository db = new SupplierRepository();
                db.Delete(SupplierId);
                success = "Supplier Delete Successfull !";
            }
            catch (Exception ex)
            {
                success = "Supplier  Delete Unsuccessfull !";
                throw ex;
            }
            return success;

        }

        #endregion

        #region Product

        public string SaveProduct(Product saveProduct)
        {
            string success = "";
            try
            {
                ProductRepository db = new ProductRepository();
                db.Add(saveProduct);
                success = "Product Save Successfull !";

            }
            catch (Exception ex)
            {
                success = "Product Save Unsuccessfull !";
                throw ex;
            }
            return success;
        }

        public IList<Product> GetAllProduct()
        {
            IList<Product> class1 = new List<Product>();
            try
            {
                ProductRepository ar = new ProductRepository();
                DataSet ds = ar.GetList();
                if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null)
                {
                    class1 = DataBaseUtil.DataTableToList<Product>(ds.Tables[0]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return class1;
        }

        public string UpdateProduct(Product updateProduct)
        {
            string success = "";
            try
            {
                ProductRepository db = new ProductRepository();
                db.Update(updateProduct);
                success = "Product Update Successfull !";
            }
            catch (Exception ex)
            {
                success = "Product Update Unsuccessfull !";
                throw ex;
            }
            return success;
        }

        public string DeleteProduct(int ProductId)
        {
            string success = "";
            try
            {
                ProductRepository db = new ProductRepository();
                db.Delete(ProductId);
                success = "Product Delete Successfull !";
            }
            catch (Exception ex)
            {
                success = "Product Delete Unsuccessfull !";
                throw ex;
            }
            return success;

        }
        
        #endregion

        #region Unit

        public string SaveUnit(Unit saveUnit)
        {
            string success = "";
            try
            {
                UnitRepository db = new UnitRepository();
                db.Add(saveUnit);
                success = "Unit save Successfull !";
            }
            catch (Exception ex)
            {

                success = "Unit save Unsuccessfull !";
                throw ex;

            }
            return success;
        }

        public IList<Unit> GetAllUnit()
        {
            IList<Unit> unit = new List<Unit>();
            try
            {
                UnitRepository ar = new UnitRepository();
                DataSet ds = ar.GetList();
                if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null)
                {
                    unit = DataBaseUtil.DataTableToList<Unit>(ds.Tables[0]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return unit;
        }

        public string UpdateUnit(Unit updateUnit)
        {
            string success = "";
            try
            {
                UnitRepository db = new UnitRepository();
                db.Update(updateUnit);
                success = "Unit Update Successfull !";
            }
            catch (Exception ex)
            {
                success = "Unit Update not Successfull !";
                throw ex;
            }
            return success;
        }

        public string DeleteUnit(int UnitId)
        {
            string success = "";
            try
            {
                UnitRepository db = new UnitRepository();
                db.Delete(UnitId);
                success = "Unit Delete Successfull !";
            }
            catch (Exception ex)
            {
                success = "Unit Delete Unsuccessfull !";
                throw ex;
            }
            return success;

        }

        #endregion
        
        #region State

        public IList<State> GetAllState()
        {
            IList<State> state = new List<State>();
            try
            {
                StateRepository ar = new StateRepository();
                DataSet ds = ar.GetList();
                if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows != null)
                {
                    state = DataBaseUtil.DataTableToList<State>(ds.Tables[0]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return state;
        }

        #endregion

    }
}
