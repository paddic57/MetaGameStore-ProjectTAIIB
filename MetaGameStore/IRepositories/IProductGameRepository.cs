using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepositories
{
    public interface IProductGameRepository
    {
        //getByProductID
        public ProductGame getByProductId(int productId);
    }
}
