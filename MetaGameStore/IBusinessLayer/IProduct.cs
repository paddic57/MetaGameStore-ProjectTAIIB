using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBusinessLayer
{
    public interface IProduct
    {
        public IEnumerable<Product> getAll();
        public Product getByProductId(int productId);
        public bool post(Product product);
        public bool put(Product product);
    }
}
