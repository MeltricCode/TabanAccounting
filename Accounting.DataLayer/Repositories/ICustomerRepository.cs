using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.ViewModel;
namespace Accounting.DataLayer.Repositories
{
    public interface ICustomerRepository
    {
        List<Customers> GetAllCustomers();

        List<ListCustomersViewModel> GetNameCustomers(string param = "");
        Customers GetCustomerById(int customer_id);

        bool InsertCustomer(Customers customer);

        bool UpdateCustomer(Customers customer);

        bool DeleteCustomer(Customers customer);

        bool DeleteCustomer(int custoemr_id);

        string GetFullnameById(int CustomerId);

    }
}
