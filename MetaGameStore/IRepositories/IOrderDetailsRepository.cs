using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepositories
{
    public interface IOrderDetailsRepository
    {
        //getByIdOrder
        public IEnumerable<OrderDetails> getByIdOrder(int orderId);
        //post
        public void post(OrderDetails orderDetails);
        //put
        public void put(int orderDetailsId, int count, int discount);
        //delete
        public void delete(int orderDetailsId);
    }
}
