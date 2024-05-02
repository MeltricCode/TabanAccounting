using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repositories;
using System.Data.Entity;
using Accounting.ViewModel;

namespace Accounting.DataLayer.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        Accounting_DBEntities db;

        public CustomerRepository(Accounting_DBEntities context)
        {
            db = context;
        }
        public List<Customers> GetAllCustomers()
        {
            return db.Customers.ToList();
        }

        public Customers GetCustomerById(int customer_id)
        {
            return db.Customers.Find(customer_id);
        }
        public bool InsertCustomer(Customers customer)
        {
            try
            {
                db.Customers.Add(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateCustomer(Customers customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteCustomer(Customers customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteCustomer(int custoemr_id)
        {
            try
            {
                DeleteCustomer(GetCustomerById(custoemr_id));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<ListCustomersViewModel> GetNameCustomers(string param = "")
        {
            if (param == "")
            {
                return db.Customers.Select(c => new ListCustomersViewModel()
                {
                    CustomerId = c.CustomerID,
                    FullName = c.FullName
                }).ToList();
            }
            return db.Customers.Where(c => c.FullName.Contains(param) || c.Email.Contains(param)).Select(c => new ListCustomersViewModel()
            {CustomerId = c.CustomerID,
                FullName = c.FullName}).ToList();
        }

        public string GetFullnameById(int CustomerId)
        {
            return db.Customers.Find(CustomerId).FullName;
        }
       
    }
}
