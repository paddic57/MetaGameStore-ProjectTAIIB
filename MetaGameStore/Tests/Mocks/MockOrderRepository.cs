using IRepositories;
using Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockRepository
{
    public class MockOrderRepository: Mock<IOrderRepository>
    {
        public MockOrderRepository mockAdd()
        {
            Setup(x => x.add(It.IsAny<Order>()));
            return this;
        }
        public MockOrderRepository mockGetByUserID(IEnumerable<Order> result)
        {
            Setup(x => x.getByUserID(It.IsAny<int>()))
                .Returns(result);
            return this;
        }

    }
}
