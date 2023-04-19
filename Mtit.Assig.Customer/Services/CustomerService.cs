﻿using Mtit.Assig.Customer.Data;

namespace Mtit.Assig.Customer.Services
{
    public class CustomerService: ICustomerService
    {
        public List<Models.Customer> GetCustomers()
        {
            return CustomerMockDataService.customers;
        }

        public Models.Customer? GetCustomer(int id)
        {
            return CustomerMockDataService.customers.FirstOrDefault(x => x.Id == id);
        }
        public Models.Customer? AddCustomer(Models.Customer customer)
        {
            CustomerMockDataService.customers.Add(customer);
            return customer;
        }

        public Models.Customer? UpdateCustomer(Models.Customer customer)
        {
            Models.Customer selectedCustomer = CustomerMockDataService.customers.FirstOrDefault(x => x.Id == customer.Id);
            if (selectedCustomer != null)
            {
                selectedCustomer.AccBalance = customer.AccBalance;
                selectedCustomer.AccType = customer.AccType;
                selectedCustomer.CribStatus = customer.CribStatus;
                selectedCustomer.Age = customer.Age;
                selectedCustomer.Name = customer.Name;
                return selectedCustomer;

            }
            return selectedCustomer;
        }

        public bool? DeleteCustomer(int id)
        {
            Models.Customer selectedCustomer = CustomerMockDataService.customers.FirstOrDefault(x => x.Id == id);
            if (selectedCustomer != null)
            {
                CustomerMockDataService.customers.Remove(selectedCustomer);
                return true;
            }
            return false;

        }
    }
}
