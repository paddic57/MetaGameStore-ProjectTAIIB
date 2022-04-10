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
    public class MockOrderDetailsRepository: Mock<IOrderDetailsRepository>
    {
        public MockOrderDetailsRepository mockGetByIdOrder(IEnumerable<OrderDetails> result)
        {
            Setup(x => x.getByIdOrder(It.IsAny<int>()))
                .Returns(result);
            return this;
        }
        public MockOrderDetailsRepository mockAdd()
        {
            Setup(x => x.add(It.IsAny<OrderDetails>()));
            return this;
        }
        public MockOrderDetailsRepository mockUpdate()
        {
            Setup(x => x.update(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>()));
            return this;
        }
        public MockOrderDetailsRepository mockDelete(bool result)
        {
            Setup(x => x.delete(It.IsAny<int>()))
                .Returns(result);
            return this;
        }
        public MockOrderDetailsRepository mockGetByOrderDetailsId(OrderDetails result)
        {
            Setup(x => x.getByOrderDetailsId(It.IsAny<int>()))
                .Returns(result);
            return this;
        }
    }
}
