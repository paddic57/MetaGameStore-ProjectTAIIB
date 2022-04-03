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
        public IEnumerable<Order> getByUserID()
        {
            return unitOfWork.order.getByUserId();
        }

        public bool post(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
