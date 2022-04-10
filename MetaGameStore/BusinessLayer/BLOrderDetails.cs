using IBusinessLayer;
using Models;
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
            if (orderDetailsId < 0)
                throw new ArgumentException("Invalid order details id");
            unitOfWork.orderDetails.delete(orderDetailsId);
            unitOfWork.Save();
            return true;
        }

        public IEnumerable<OrderDetails> getByIdOrder(int orderId)
        {
            return unitOfWork.orderDetails.getByIdOrder(orderId);
        }

        public OrderDetails getByOrderDetailsId(int orderDetailsId)
        {
            return unitOfWork.orderDetails.getByOrderDetailsId(orderDetailsId);
        }

        public bool post(OrderDetails orderDetails)
        {
            if (orderDetails != null)
            {
                throw new ArgumentException("Invalid order details");
            }
            unitOfWork.orderDetails.post(orderDetails);
            unitOfWork.Save();
            return true;
        }

        public bool put(int orderDetailsId, int count, int discount)
        {
            if (orderDetailsId < 0)
                throw new ArgumentException("Invalid order details id");
            if (count < 0)
                throw new ArgumentException("Invalid count");
            if (discount < 0)
                throw new ArgumentException("Invalid discount");
            unitOfWork.orderDetails.put(orderDetailsId, count, discount);
            unitOfWork.Save();
            return true;
        }
    }
}
