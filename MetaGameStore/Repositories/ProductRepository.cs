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

        public IEnumerable<Product> getProducts()
        {
            return this.context.Products;
        }

        public Product getByProductId(int productId)
        {
            return this.context.Products.Where(x => x.Id == productId).Single();
        }

        public void add(Product product)
        {
            this.context.Products.Add(product);
        }

        public void update(Product product)
        {
            Product p = getByProductId(product.Id);
            if (p != null)
            {
                p.Price = product.Price;
                p.Photo = product.Photo;
                p.Producer = product.Producer;
                p.Count = product.Count;
                p.Name = product.Name;
                p.Desription = product.Desription;
            }
        }
        public void delete(Product product)
        {
            if (product != null)
            {
                this.context.Products.Remove(product);
            }
        }
    }
}
