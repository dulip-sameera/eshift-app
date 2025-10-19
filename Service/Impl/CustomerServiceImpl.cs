using eshift.Dto;
using eshift.Model;
using eshift.Dao;
using eshift.Dao.Impl;
using eshift.Utils.Mapper;
using eshift.Utils.Generator;
using System.Collections.Generic;
using eshift.Enums;

namespace eshift.Service.Impl
{
    internal class CustomerServiceImpl : ICustomerService
    {
        private readonly ICustomerDao customerDao = new CustomerDaoImpl();

        public List<CustomerGridDto> GetAllCustomersForGrid()
        {
            var models = customerDao.GetAllCustomersWithUsernames();
            var gridDtos = new List<CustomerGridDto>();
            foreach (var tuple in models)
            {
                gridDtos.Add(CustomerMapper.ToGridDto(tuple.Item1, tuple.Item2));
            }
            return gridDtos;
        }

        public CustomerGridDto? GetCustomerForGridByCusId(string cusId)
        {
            var tuple = customerDao.GetCustomerWithUsernameByCusId(cusId);
            return tuple != null ? CustomerMapper.ToGridDto(tuple.Value.Item1, tuple.Value.Item2) : null;
        }

        public void DeleteCustomerByCusId(string cusId)
        {
            var tuple = customerDao.GetCustomerWithUsernameByCusId(cusId);
            if (tuple == null)
                throw new KeyNotFoundException("Customer not found for deletion.");

            bool updated = customerDao.UpdateCustomerStatusByCusId(cusId, (int)CustomerStatusEnum.DELETED);
            if (!updated)
                throw new Exception("Failed to delete customer.");
        }

        public string CreateCustomer(CustomerDto customer)
        {
            // Generate CusId if not provided
            string cusId = string.IsNullOrWhiteSpace(customer.CusId) ? Utils.Generator.CustomerIdGenerator.GenerateNextCustomerId() : customer.CusId;

            // Check if customer already exists
            var tuple = customerDao.GetCustomerWithUsernameByCusId(cusId);
            if (tuple != null)
                throw new ArgumentException("Customer with this ID already exists.");

            var status = customer.Status ?? new CustomerStatusDto((int)CustomerStatusEnum.ACTIVE, "ACTIVE");
            var model = new CustomerModel(
                id: null,
                cusId: cusId,
                firstName: customer.FirstName,
                lastName: customer.LastName,
                phone: customer.Phone,
                email: customer.Email,
                address: customer.Address,
                city: customer.City,
                zipCode: customer.ZipCode,
                status: new CustomerStatusModel(status.Id, status.Name),
                userAccount: null
                );
            bool created = customerDao.CreateCustomer(model);
            if (!created)
                throw new Exception("Failed to create customer.");
            return cusId;
        }

        public void UpdateCustomer(string cusId, CustomerDto customer)
        {
            var tuple = customerDao.GetCustomerWithUsernameByCusId(cusId);
            if (tuple == null)
                throw new KeyNotFoundException("Customer not found for update.");

            if (cusId != customer.CusId)
                throw new ArgumentException("Customer ID cannot be changed.");

            var errors = Utils.Validation.CustomerValidator.Validate(
                customer.FirstName,
                customer.LastName,
                customer.Email,
                customer.Phone,
                customer.Address,
                customer.City,
                customer.ZipCode
            );
            if (errors.Count > 0)
                throw new ArgumentException("Validation errors: " + string.Join(", ", errors.Values));

            // Use status from DTO (set by form)
            var status = customer.Status ?? new CustomerStatusDto((int)CustomerStatusEnum.ACTIVE, CustomerStatusEnum.ACTIVE.ToString());
            var model = new CustomerModel(
                tuple.Value.Item1.Id,
                cusId,
                customer.FirstName,
                customer.LastName,
                customer.Email,
                customer.Phone,
                customer.Address,
                customer.City,
                customer.ZipCode,
                new CustomerStatusModel(status.Id, status.Name),
                tuple.Value.Item1.UserAccount // preserve existing user account
            );
            bool updated = customerDao.UpdateCustomer(cusId, model);
            if (!updated)
                throw new Exception("Failed to update customer.");
        }

        public CustomerDto? GetCustomerByCusId(string cusId)
        {
            try
            {
                var customer = customerDao.GetCustomerByCusId(cusId);
                if (customer == null)
                    return null;
                return CustomerMapper.ToDto(customer);
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving customer: " + ex.Message);
            }
        }
    }
}