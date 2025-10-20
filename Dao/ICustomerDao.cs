using eshift.Model;
using System.Collections.Generic;

namespace eshift.Dao
{
    internal interface ICustomerDao
    {
        List<(CustomerModel, string)> GetAllCustomersWithUsernames();
        (CustomerModel, string)? GetCustomerWithUsernameByCusId(string cusId);
        bool UpdateCustomerStatusByCusId(string cusId, int statusId);
        bool CreateCustomer(CustomerModel customer);
        bool UpdateCustomer(string cusId, CustomerModel customer);
        string? GetLastCustomerId();
        CustomerModel? GetCustomerByCusId(string cusId);
        CustomerModel? GetCustomerByUseraccount(int userAccount);
        CustomerModel? GetCustomerById(int id);
        int GetTotalCustomersCount();
        int GetTotalCustomersCountByStatus(int statusId);
    }
}