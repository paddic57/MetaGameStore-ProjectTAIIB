using IRepositories;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderDetailsRepository : IOrderDetailsRepository
    {
        private readonly MyContext context;

        public OrderDetailsRepository(MyContext context)
        {
            this.context = context;
        }
        public OrderDetails getByOrderDetailsId(int orderDetailsId)
        {
            return this.context.OrderDetails.Where(x => x.Id == orderDetailsId).FirstOrDefault();
        }
        public void delete(int orderDetailsId)
        {
            OrderDetails od = getByOrderDetailsId(orderDetailsId);
            if (od != null)
            {
                this.context.Remove(od);
            }
        }

        public IEnumerable<OrderDetails> getByIdOrder(int orderId)
        {
            return this.context.OrderDetails.Where(y => y.IdOrder == orderId).ToList();
        }

        public void add(OrderDetails orderDetails)
        {
            this.context.Add(orderDetails);
        }

        public void update(int orderDetailsId, int count, int discount)
        {
            OrderDetails od = getByOrderDetailsId(orderDetailsId);
            if (od != null)
            {
                od.ProductCount = count;
                od.ProductDiscount = discount;
            }
        }
    }
}
