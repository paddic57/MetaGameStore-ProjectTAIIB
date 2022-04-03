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
            return unitOfWork.product.getAll();
        }

        public Product getByProductId(int productId)
        {
            if (productId < 0)
                throw new ArgumentException("Invalid product id");
            return unitOfWork.product.getByProductId(productId);
        }

        public bool post(Product product)
        {
            if (product != null)
                throw new ArgumentException("Invalid product");
            unitOfWork.product.post(product);
            unitOfWork.Save();
            return true;
        }

        public bool put(Product product)
        {
            if (product != null)
                throw new ArgumentException("Invalid product");
            unitOfWork.product.put(product);
            unitOfWork.Save();
            return true;
        }
    }
}
