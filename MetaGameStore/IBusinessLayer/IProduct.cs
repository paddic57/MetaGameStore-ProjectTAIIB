using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBusinessLayer
{
    public interface IProduct
    {
        public IEnumerable<Product> getProducts();
        public Product getByProductId(int productId);
        public void add(Product product);
        public void update(Product product);
    }
}
