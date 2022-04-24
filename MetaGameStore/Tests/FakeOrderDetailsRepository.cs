using IRepositories;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class FakeOrderDetailsRepository
    {
        private readonly List<OrderDetails> orderDetailsList = new List<OrderDetails>();

        public bool delete(int orderDetailsId)
        {
            orderDetailsList.RemoveAt(orderDetailsId);
            return true;
        }
        public bool add(OrderDetails orderDetails)
        {
            orderDetailsList.Add(orderDetails);
            return true;
        }
    }
}
