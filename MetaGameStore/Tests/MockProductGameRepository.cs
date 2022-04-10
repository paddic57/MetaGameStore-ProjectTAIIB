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
    public class MockProductGameRepository: Mock<IProductGameRepository>
    {
        public MockProductGameRepository mockGetByProductId(ProductGame result)
        {
            Setup(x => x.getByProductId(It.IsAny<int>()))
                .Returns(result);
            return this;
        }

        public MockProductGameRepository verifyGetByProductId(Times times)
        {
            Verify(x => x.getByProductId(It.IsAny<int>()), times);
            return this;
        }
    }
}
