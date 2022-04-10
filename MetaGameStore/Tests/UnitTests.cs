using BusinessLayer;
using MockRepository;
using Models;
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
        public UnitOfWorkTests unitOfWorkTest;

        [Fact]
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

            /*{

                var mockRepository = new MockRepository<Genre>();
                mockRepository.Setup(r => r.Get(It.IsAny<int>()))
                    .Returns(new Genre { Name = "Action" });

                testUnitOfWork.GenreRepository = mockRepository.Object;

                BLGenre bLGenre = new BLGenre(testUnitOfWork);

                Genre genre = bLGenre.Get(1);

                Assert.Equal("Action", genre.Name);
            }*/
            //BLOrderDetails bLOrderDetails = new BLOrderDetails(unitOfWorkTest);
            unitOfWorkTest.orderDetails = mockOrderDetailsList.Object;

        }
    }
}
