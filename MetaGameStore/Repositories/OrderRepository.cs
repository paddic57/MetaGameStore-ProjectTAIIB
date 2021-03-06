using IRepositories;
using Models;
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

        public void add(Order order)
        {
            this.context.Orders.Add(order);
        }
        public IEnumerable<Order> getOrders()
        {
            return this.context.Orders;
        }
    }
}
