using eshift.Dto;
using System.Collections.Generic;

namespace eshift.Controller
{
    internal interface ICustomerController
    {
        List<CustomerGridDto>? GetAllCustomersForGrid();
        CustomerGridDto? GetCustomerForGridByCusId(string cusId);
        void DeleteCustomerByCusId(string cusId);
        string CreateCustomer(CustomerDto customer); // Returns generated CusId
        void UpdateCustomer(string cusId, CustomerDto customer);

        CustomerDto? GetCustomerByCusId(string cusId);
    }
}
