using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repositories;
using Accounting.DataLayer.Services;

namespace Accounting.DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        Accounting_DBEntities db = new Accounting_DBEntities();

        private ICustomerRepository _customerrepository;

        public ICustomerRepository CustomerRepository { get 
            { 
                if(_customerrepository == null)
                {
                    ICustomerRepository Customer = new CustomerRepository(db);
                    _customerrepository = Customer;
                    
                }
                return _customerrepository;
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
