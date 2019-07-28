using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Demo.Data.Repository;
using Demo.Data.Entities;

namespace Demo.Api.Controllers
{
    public class ApiBaseController: ControllerBase
    {
        public IDemoRepository<Order> OrderRepository;
        public IDemoRepository<OrderDetail> OrderDetailRepository;
        public IDemoRepository<Product> ProductRepository;
        public IDemoRepository<Customer> CustomerRepository;

        public ApiBaseController(IDemoRepository<Order> orderRepository, IDemoRepository<OrderDetail> orderDetailRepository, IDemoRepository<Product> productRepository, IDemoRepository<Customer> customerRepository)
        {
            OrderRepository = orderRepository;
            OrderDetailRepository = orderDetailRepository;
            ProductRepository = productRepository;
            CustomerRepository = customerRepository;
        }
    }
}
