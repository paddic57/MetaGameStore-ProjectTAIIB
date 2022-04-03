using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBusinessLayer
{
    public interface IOrder
    {
        public bool post(Order order);
        public IEnumerable<Order> getByUserID();

    }
}
