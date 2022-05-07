using IBusinessLayer;
using IRepositories;
using Models;
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
        private readonly IUnitOfWork unitOfWork;
        public BLOrder(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void add(Order order)
        {
            if (order != null)
                throw new ArgumentException("Invalid order");

            unitOfWork.order.add(order);
            unitOfWork.Save();
        }

        public IEnumerable<Order> getByUserID(int userId)
        {
            return unitOfWork.order.getByUserID(userId);
        }

        public IEnumerable<Order> getOrders()
        {
            return unitOfWork.order.getOrders();
        }

    }
}
