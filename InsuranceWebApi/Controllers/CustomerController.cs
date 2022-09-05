using InsuranceWebApi.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceWebApi.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomer _CustomerService;

        public CustomerController(ICustomer CustomerServisce)
        {
            _CustomerService = CustomerServisce;
        }
        //[HttpDelete]
        //public bool Delete(int CustId)
        //{
        //    bool isDeleted = _CustomerService.DeleteEmployeeById(CustId);
        //    return isDeleted;
        //}


        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _CustomerService.GetAllUser() as IEnumerable<Customer>;
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var a= _CustomerService.GeTCustomerDetailsById(id);
             return Ok (a);
        }

    }
}
