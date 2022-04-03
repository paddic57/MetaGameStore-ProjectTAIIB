using IRepositories;
using Models;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly MyContext context;

        public OrderRepository(MyContext context)
        {
            this.context = context;
        }

        public IEnumerable<Order> getByUserID(int userId)
        {
            return this.context.Orders.Where(x => x.User.Id == userId);
        }

        public void post(Order order)
        {
            this.context.Orders.Add(order);
        }
    }
}
