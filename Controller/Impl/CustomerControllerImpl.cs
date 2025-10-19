using eshift.Controller;
using eshift.Dto;
using eshift.Service;
using eshift.Service.Impl;
using System.Collections.Generic;

namespace eshift.Controller.Impl
{
    internal class CustomerControllerImpl : ICustomerController
    {
        private readonly ICustomerService customerService;

        public CustomerControllerImpl()
        {
            customerService = new CustomerServiceImpl();
        }

        public List<CustomerGridDto>? GetAllCustomersForGrid()
        {
            return customerService.GetAllCustomersForGrid();
        }

        public CustomerGridDto? GetCustomerForGridByCusId(string cusId)
        {
            return customerService.GetCustomerForGridByCusId(cusId);
        }

        public void DeleteCustomerByCusId(string cusId)
        {
            customerService.DeleteCustomerByCusId(cusId);
        }

        public string CreateCustomer(CustomerDto customer)
        {
            return customerService.CreateCustomer(customer);
        }

        public void UpdateCustomer(string cusId, CustomerDto customer)
        {
            customerService.UpdateCustomer(cusId, customer);
        }

        public CustomerDto? GetCustomerByCusId(string cusId)
        {
            return customerService.GetCustomerByCusId(cusId);
        }
    }
}
