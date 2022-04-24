using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepositories
{
    public interface IOrderDetailsRepository
    {
        public IEnumerable<OrderDetails> getByIdOrder(int orderId);
        public bool add(OrderDetails orderDetails);
        public void update(int orderDetailsId, int count, int discount);
        public bool delete(int orderDetailsId);
        public OrderDetails getByOrderDetailsId(int orderDetailsId);
        /*public IEnumerable<OrderDetails> getAll();*/
    }
}
