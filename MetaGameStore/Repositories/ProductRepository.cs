using IRepositories;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly MyContext context;

        public ProductRepository(MyContext context)
        {
            this.context = context;
        }

        public IEnumerable<Product> getAll()
        {
            return this.context.Products;
        }

        public Product getByProductId(int productId)
        {
            return this.context.Products.Where(x => x.id == productId).Single();
        }

        public void post(Product product)
        {
            this.context.Products.Add(product);
        }

        public void put(Product product)
        {
            Product p = getByProductId(product.id);
            if (p != null)
            {
                p.price = product.price;
                p.photo = product.photo;
                p.producer = product.producer;
                p.count = product.count;
                p.name = product.name;
                p.desription = product.desription;
            }
        }
        public bool delete(Product product)
        {
            if (product != null)
            {
                this.context.Products.Remove(product);
                return true;
            }
            return false;
        }
    }
}
