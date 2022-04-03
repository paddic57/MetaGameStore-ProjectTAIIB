using IRepositories;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductGameRepository : IProductGameRepository
    {
        private readonly UnitOfWork unitOfWork;

        public ProductRepository(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }


        public ProductGame getByProductId(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
