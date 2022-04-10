using IRepositories;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductGameRepository : IProductGameRepository
    {
        private readonly MyContext context;

        public ProductGameRepository(MyContext context)
        {
            this.context = context;
        }


        public ProductGame getByProductId(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
