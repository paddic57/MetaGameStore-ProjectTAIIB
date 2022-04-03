using IRepositories;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderDetailsRepository : IOrderDetailsRepository
    {
        public void delete(int orderDetailsId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDetails> getByIdOrder(int orderId)
        {
            throw new NotImplementedException();
        }

        public void post(OrderDetails orderDetails)
        {
            throw new NotImplementedException();
        }

        public void put(int orderDetailsId, int count, int discount)
        {
            throw new NotImplementedException();
        }
    }
}
