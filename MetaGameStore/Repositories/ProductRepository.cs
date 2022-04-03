using IRepositories;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly UnitOfWork unitOfWork;

        public ProductRepository(UnitOfWork unitOfWork)
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

        public void post(Product product)
        {
            throw new NotImplementedException();
        }

        public void put(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
