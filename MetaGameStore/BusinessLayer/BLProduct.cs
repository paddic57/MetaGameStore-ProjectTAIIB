using IBusinessLayer;
using Models.Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BLProduct : IProduct
    {
        private readonly UnitOfWork unitOfWork;
        public BLProduct(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public IEnumerable<Product> getAll()
        {
            throw new NotImplementedException();
        }

        public Product getByProductId(int productId)
        {
            throw new NotImplementedException();
        }

        public bool post(Product product)
        {
            throw new NotImplementedException();
        }

        public bool put(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
