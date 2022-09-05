using InsuranceWebApi.Interface;
using System.Collections;
using Microsoft.Data.SqlClient;
namespace InsuranceWebApi.Service
{
    public class CustomerService : ICustomer
    {

        private readonly insuranceContext? _Context;
        public CustomerService(insuranceContext context)
        {
            _Context = context;
        }
        public bool AddEmployeeData(Customer e)
        {
            _Context.Customers.Add(e);

            bool isEmployeeAdded = _Context.SaveChanges() > 0;
            return isEmployeeAdded;

        }

        public bool DeleteEmployeeById(int CustId)
        {
            var deleteEmployee = _Context.Customers.FirstOrDefault(t => t.CustId == CustId);
            bool isDeleted = false;
            if (deleteEmployee != null)
            {
                _Context.Customers.Remove(deleteEmployee);
                isDeleted = _Context.SaveChanges() > 0;
            }
            return isDeleted;
        }

        public IEnumerable<Customer> GetAllUser()
        {

            return _Context.Customers;
            
        }


        public IEnumerable<Customer> GeTCustomerDetailsById(int id)
        {
            var b= _Context.Customers.Where(C => C.CustId == id);
            return b;
        }
    }
}

