using IRepositories;
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
        public IEnumerable<Order> getByUserID()
        {
            throw new NotImplementedException();
        }

        public void post(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
