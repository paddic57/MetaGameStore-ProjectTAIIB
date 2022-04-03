using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBusinessLayer
{
    public interface IOrderDetails
    {
        public IEnumerable<OrderDetails> getByIdOrder(int orderId);
        public bool post(OrderDetails orderDetails);
        public bool put(int orderDetailsId, int count, int discount);
        public bool delete(int orderDetailsId);
        public OrderDetails getByOrderDetailsId(int orderDetailsId);
    }
}
