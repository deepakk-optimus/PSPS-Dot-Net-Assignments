using KickOff.Controllers;
using KickOff.Models;
using KickOff.ModelView;
using KickOff.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Hosting;
using System.Web.Http.Results;
using System.Web.Http.Routing;

namespace KickOffUnitTest
{

    [TestClass]
    public class CustomerControllerTest
    {

        [TestMethod]
        public void GetCustomerTest()
        {
            var mockRepository = new Mock<ICustomerRepository>();
            mockRepository.Setup(x => x.GetCustomer(42))
                .Returns(new Customer { Id = 42 , CustomerName = "TestCustomer"});

            var controller = new CustomerController(mockRepository.Object);
            //controller.Request = new HttpRequestMessage(HttpMethod.Get, "http://localhost/api");
            //controller.Configuration = new HttpConfiguration();

            // Act
            IHttpActionResult actionResult = controller.GetCustomer("42");
            var contentResult = actionResult as OkNegotiatedContentResult<CustomerModelView>;

            // Assert
            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
            Assert.AreEqual(42, contentResult.Content.Id);
        }
    }
}
