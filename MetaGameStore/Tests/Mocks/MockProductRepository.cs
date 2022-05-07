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
        public MockProductRepository mockGetAll(IEnumerable<Product> result)
        {
            Setup(x => x.getProducts())
                .Returns(result);
            return this;
        }
        public MockProductRepository mockGetByProductId(Product result)
        {
            Setup(x => x.getByProductId(It.IsAny<int>()))
                .Returns(result);
            return this;
        }
        public MockProductRepository mockPost()
        {
            Setup(x => x.add(It.IsAny<Product>()));
            return this;
        }
        public MockProductRepository mockUpdate()
        {
            Setup(x => x.update(It.IsAny<Product>()));
            return this;
        }
        public MockProductRepository mockDelete()
        {
            Setup(x => x.delete(It.IsAny<Product>()));
            return this;
        }
    }
}
