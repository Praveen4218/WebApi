using System.Collections;

namespace InsuranceWebApi.Interface
{
    public interface ICustomer
    {
        public bool DeleteEmployeeById(int CustId);
        public bool AddEmployeeData(Customer e);

        public IEnumerable<Customer> GetAllUser();
        public IEnumerable<Customer> GeTCustomerDetailsById(int id);
    }
}
