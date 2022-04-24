using BusinessLayer;
using IRepositories;
using MockRepository;
using Models;
using Moq;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class UnitTests
    {
        
        [Fact(DisplayName = "OrderDetails post (dummy)")]
        public void orderDetailsGetById1_TestValid()
        {
            int id = 1;

        }
        [Fact(DisplayName = "OrderDetails post (stub)")]
        public void orderDetailsAdd1_TestValid()
        {
            var orderDetail = new OrderDetails
            {
                Id = 1,
                productCount = 2,
                productPrice = 3.99,
                idProduct = 1,
                idOrder = 1
            };
            IOrderDetailsRepository orderDetails = Mock.Of<IOrderDetailsRepository>();
            Assert.Equal(true, orderDetails.add(orderDetail)); 

        }
        [Fact(DisplayName = "OrderDetails add (fakeRepo)")]
        public void orderDetailsAdd2_TestValid()
        {
            var orderDetail = new OrderDetails
            {
                Id = 1,
                productCount = 2,
                productPrice = 3.99,
                idProduct = 1,
                idOrder = 1
            };

            var orderDetailsRepository = new FakeOrderDetailsRepository();
            Assert.Equal(true, orderDetailsRepository.add(orderDetail));
        }
        [Fact(DisplayName = "OrderDetails add (spy)")]
        public void orderDetailsDelete_TestValid()
        {
            
        }


    }
}
