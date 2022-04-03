using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepositories
{
    public interface IOrderRepository
    {
        //post
        public void post(Order order);
        //getByUserID
        public IEnumerable<Order> getByUserID(int userId);
        //?get-all?
    }
}
