using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepositories
{
    public interface IOrderRepository
    {
        public void post(Order order);
        public IEnumerable<Order> getByUserID(int userId);
    }
}
