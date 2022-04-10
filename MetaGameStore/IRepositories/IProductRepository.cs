using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepositories
{
    public interface IProductRepository
    {
        //get-all
        public IEnumerable<Product> getAll();
        //getByProductId
        public Product getByProductId(int productId);
        //post
        public void post(Product product);
        //put
        public void put(Product product);
        //delete
        public bool delete(Product product);
    }
}
