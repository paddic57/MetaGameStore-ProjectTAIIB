using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xunit;
using Repositories;

namespace Tests
{
    public class InMemoryTests
    {
        private readonly MyContext context;

        public InMemoryTests()
        {
            DbContextOptionsBuilder dbOptions = new DbContextOptionsBuilder<MyContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString());
            context = new MyContext(dbOptions.Options);
        }

        [Fact(DisplayName = "OrderDetails add (in memory)")]
        public void orderDetailsAdd_ValidTest()
        {
            var con = new OrderDetailsRepository(context);

            var orderDetail = new OrderDetails
            {
                Id = 1,
                productCount = 2,
                productPrice = 3.99,
                idProduct = 1,
                idOrder = 1
            };

            bool result = con.add(orderDetail);

            Assert.True(result);

        }

        [Fact(DisplayName = "OrderDetails get by id order  (in memory)")]

        public void orderDetailsGetByIdOrder_ValidTest()
        {
            var con = new OrderDetailsRepository(context);

            var orderDetailsList = new List<OrderDetails>()
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
            context.OrderDetails.AddRange(orderDetailsList);
            context.SaveChanges();

            IEnumerable<OrderDetails> result = con.getByIdOrder(1);

            Assert.Equal(2, result.Count());

        }

        [Fact(DisplayName = "OrderDetails get by order details (in memory)")]

        public void orderDetailsGetByIdOrderDetails_ValidTest()
        {
            var con = new OrderDetailsRepository(context);

            var orderDetailsList = new List<OrderDetails>()
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
            context.OrderDetails.AddRange(orderDetailsList);
            context.SaveChanges();

            OrderDetails result = con.getByOrderDetailsId(2);

            Assert.Equal(5.99, result.productPrice);

        }

        [Fact(DisplayName = "OrderDetails delete (in memory)")]
        public void orderDetailsDeleteOrderDetails_ValidTest()
        {
            var con = new OrderDetailsRepository(context);

            var orderDetailsList = new List<OrderDetails>()
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
            context.OrderDetails.AddRange(orderDetailsList);
            context.SaveChanges();

            bool result = con.delete(1);

            Assert.True(result);

        }
    }
}
