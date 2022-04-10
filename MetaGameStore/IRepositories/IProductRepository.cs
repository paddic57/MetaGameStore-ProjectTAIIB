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
        public IEnumerable<Product> getAll();
        public Product getByProductId(int productId);
        public void add(Product product);
        public void update(Product product);
        public bool delete(Product product);
    }
}
