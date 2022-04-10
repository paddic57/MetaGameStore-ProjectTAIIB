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
    public class MockProductRepository: Mock<IProductRepository>
    {
        public MockProductRepository getAll(IEnumerable<Product> result)
        {
            Setup(x => x.getAll())
                .Returns(result);
            return this;
        }
        public MockProductRepository getByProductId(Product result)
        {
            Setup(x => x.getByProductId(It.IsAny<int>()))
                .Returns(result);
            return this;
        }
        public MockProductRepository post()
        {
            Setup(x => x.post(It.IsAny<Product>()));
            return this;
        }
        public MockProductRepository mockPut()
        {
            Setup(x => x.put(It.IsAny<Product>()));
            return this;
        }
        public MockProductRepository mockDelete(bool result)
        {
            Setup(x => x.delete(It.IsAny<Product>()))
                .Returns(result);
            return this;
        }
    }
}
