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
        [Fact(DisplayName = "OrderDetails by IdOrderDetails")]
        public void orderDetailsGetByIdOrderDetails_TestValid()
        {
            var mockOrderDetailsList = new List<OrderDetails>()
            {
                new OrderDetails()
                {
                    Id = 1,
                    productCount = 2,
                    productPrice = 3.99,
                    idProduct = 1,
                    idOrder = 1,
                },
                new OrderDetails()
                {
                    Id = 2,
                    productCount = 2,
                    productPrice = 5.99,
                    idProduct = 2,
                    idOrder = 2,
                },
                new OrderDetails()
                {
                    Id = 3,
                    productCount = 1,
                    productPrice = 10.99,
                    idProduct = 3,
                    idOrder = 1,
                }
            };
            var mockOrderDetailsRepo = new MockOrderDetailsRepository().mockGetByOrderDetailsId(mockOrderDetailsList);


            var testUnitOfWork = new UnitOfWorkTests();

            testUnitOfWork.orderDetails = mockOrderDetailsRepo.Object;
            var service = new BLOrderDetails(testUnitOfWork);



            OrderDetails result = service.getByOrderDetailsId(1);

            Assert.NotNull(result);
            Assert.Equal(3.99, result.productPrice);
        }
        [Fact(DisplayName = "OrderDetails by IdOrder")]
        public void orderDetailsGetByIdOrder_TestValid()
        {
            var mockOrderDetailsList = new List<OrderDetails>()
            {
                new OrderDetails()
                {
                    Id = 1,
                    productCount = 2,
                    productPrice = 3.99,
                    idProduct = 1,
                    idOrder = 1,
                },
                new OrderDetails()
                {
                    Id = 2,
                    productCount = 2,
                    productPrice = 5.99,
                    idProduct = 2,
                    idOrder = 2,
                },
                new OrderDetails()
                {
                    Id = 3,
                    productCount = 1,
                    productPrice = 10.99,
                    idProduct = 3,
                    idOrder = 1,
                }
            };
            var mockOrderDetailsRepo = new MockOrderDetailsRepository().mockGetByIdOrder(mockOrderDetailsList);


            var testUnitOfWork = new UnitOfWorkTests();

            testUnitOfWork.orderDetails = mockOrderDetailsRepo.Object;
            var service = new BLOrderDetails(testUnitOfWork);

            

            List<OrderDetails> result = service.getByIdOrder(1) as List<OrderDetails>;

            Assert.NotNull(result);
            Assert.Equal(3, result.Count);
        }
       
    }
}
