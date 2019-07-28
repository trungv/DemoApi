using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Demo.Data.Repository;
using Demo.Data.Entities;

namespace Demo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ApiBaseController
    {
        public ValuesController(IDemoRepository<Order> orderRepository, IDemoRepository<OrderDetail> orderDetailRepository, IDemoRepository<Product> productRepository, IDemoRepository<Customer> customerRepository)
            : base(orderRepository, orderDetailRepository, productRepository, customerRepository)
        {
        }
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            //List<Order> orderViewModelList = new List<Order>();

            //var orderList = OrderRepository.GetAll;

            return Ok("ok");
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
