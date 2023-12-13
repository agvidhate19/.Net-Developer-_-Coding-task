using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReactAPICoreCurd.Model;
using ReactAPICoreCurd.Data;

namespace ReactAspCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ReactAPICoreCurdContext _CustomerDbContext;

        public CustomerController(ReactAPICoreCurdContext customerDbContext)
        {
            _CustomerDbContext = customerDbContext;
        }

        [HttpGet]
        [Route("GetCustomer")]
        public async Task<IEnumerable<customerDetails>> GetCustomer()
        {
            return await _CustomerDbContext.customerDetails.ToListAsync();
        }

        [HttpPost]
        [Route("AddCustomer")]
        public async Task<customerDetails> AddCustomer(customerDetails objCustomer)
        {
            _CustomerDbContext.customerDetails.Add(objCustomer);
            await _CustomerDbContext.SaveChangesAsync();
            return objCustomer;
        }

        [HttpPatch]
        [Route("UpdateCustomer/{id}")]
        public async Task<customerDetails> UpdateCustomer(customerDetails objCustomer)
        {
            _CustomerDbContext.Entry(objCustomer).State = EntityState.Modified;
            await _CustomerDbContext.SaveChangesAsync();
            return objCustomer;
        }

        [HttpDelete]
        [Route("DeleteCustomer/{id}")]
        public bool DeleteCustomer(int id)
        {
            bool a = false;
            var customer = _CustomerDbContext.customerDetails.Find(id);
            if (customer != null)
            {
                a = true;
                _CustomerDbContext.Entry(customer).State = EntityState.Deleted;
                _CustomerDbContext.SaveChanges();
            }
            else
            {
                a = false;
            }
            return a;

        }

    }

}