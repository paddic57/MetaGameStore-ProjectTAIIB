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
            return this.context.OrderDetails.Where(x => x.Id == orderDetailsId).Single();
        }
        public bool delete(int orderDetailsId)
        {
            OrderDetails od = getByOrderDetailsId(orderDetailsId);
            if (od != null)
            {
                this.context.Remove(od);
                return true;
            }
            return false;
        }

        public IEnumerable<OrderDetails> getByIdOrder(int orderId)
        {
            return this.context.OrderDetails.Where(x => orderId == x.Order.id);
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
                od.productCount = count;
                od.productDiscount = discount;
            }
        }
    }
}
