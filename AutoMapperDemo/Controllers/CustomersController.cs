using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapperDemo.Data.Entities;
using AutoMapperDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IMapper _mapper;

        public CustomersController(IMapper mapper)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public ActionResult Index()
        {
            var customerEntity = new CustomerEntity
            {
                CustomerId = 123141,
                FirstName = "Peter",
                LastName = "Lemonjello",
                CreateDate = DateTime.Now,
            };

            var customer = _mapper.Map<Customer>(customerEntity);

            return Ok(customer);
        }
    }
}