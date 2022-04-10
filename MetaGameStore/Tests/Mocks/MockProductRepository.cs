﻿using IRepositories;
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
            Setup(x => x.getAll())
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
        public MockProductRepository mockDelete(bool result)
        {
            Setup(x => x.delete(It.IsAny<Product>()))
                .Returns(result);
            return this;
        }

        public MockProductRepository verifyAdd(Times times)
        {
            Verify(x => x.add(It.IsAny<Product>()), times);
            return this;
        }
        public MockProductRepository verifyUpdate(Times times)
        {
            Verify(x => x.update(It.IsAny<Product>()), times);
            return this;
        }
        public MockProductRepository verifyDelete(Times times)
        {
            Verify(x => x.delete(It.IsAny<Product>()), times);
            return this;
        }
        public MockProductRepository verifyGetByProductId(Times times)
        {
            Verify(x => x.getByProductId(It.IsAny<int>()), times);
            return this;
        }
        public MockProductRepository verifyGetAll(Times times)
        {
            Verify(x => x.getAll(),times);
            return this;
        }
    }
}