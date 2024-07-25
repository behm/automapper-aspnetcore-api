using AutoMapper;
using AutoMapperDemo.Controllers;
using AutoMapperDemo.Mapping;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoMapperDemo.Tests
{
    [TestClass]
    public class CustomerControllerTests
    {
        private IMapper _mapper;

        [TestInitialize]
        public void TestInitialize()
        {
            var configuration = new MapperConfiguration(config =>
            {
                config.AddProfile<CustomerProfile>();
            });

            configuration.AssertConfigurationIsValid();

            _mapper = new Mapper(configuration);
        }

        [TestMethod]
        public void Index_ReturnsOkResult()
        {
            // Arrange
            var controller = new CustomersController(_mapper);

            // Act
            var result = controller.Index();

            // Assert
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }
    }
}
