using IBusinessLayer;
using Models.Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BLOrder : IOrder
    {
        private readonly UnitOfWork unitOfWork;
        public BLOrder(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Order> getByUserID(int userId)
        {
            return unitOfWork.order.getByUserID(userId);
        }

        public bool post(Order order)
        {
            if(order != null)
                throw new ArgumentException("Invalid order");

            unitOfWork.order.post(order);
            unitOfWork.Save();
            return true;
        }
    }
}
