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
    public class BLOrderDetails : IOrderDetails
    {
        private readonly UnitOfWork unitOfWork;
        public BLOrderDetails(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public bool delete(int orderDetailsId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDetails> getByIdOrder(int orderId)
        {
            throw new NotImplementedException();
        }

        public bool post(OrderDetails orderDetails)
        {
            throw new NotImplementedException();
        }

        public bool put(int orderDetailsId, int count, int discount)
        {
            throw new NotImplementedException();
        }
    }
}
