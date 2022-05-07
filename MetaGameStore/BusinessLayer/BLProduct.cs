using IBusinessLayer;
using IRepositories;
using Models;
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
        private readonly IUnitOfWork unitOfWork;
        public BLProduct(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public IEnumerable<Product> getProducts()
        {
            return unitOfWork.product.getProducts();
        }

        public Product getByProductId(int productId)
        {
            if (productId < 0)
                throw new ArgumentException("Invalid product id");
            return unitOfWork.product.getByProductId(productId);
        }

        public void add(Product product)
        {
            if (product != null)
                throw new ArgumentException("Invalid product");
            unitOfWork.product.add(product);
            unitOfWork.Save();
        }

        public void update(Product product)
        {
            if (product != null)
                throw new ArgumentException("Invalid product");
            unitOfWork.product.update(product);
            unitOfWork.Save();
        }
    }
}
