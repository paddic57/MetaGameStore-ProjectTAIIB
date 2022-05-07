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
    public class BLOrderDetails : IOrderDetails
    {
        private readonly IUnitOfWork unitOfWork;
        public BLOrderDetails(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void delete(int orderDetailsId)
        {
            if (orderDetailsId < 0)
                throw new ArgumentException("Invalid order details id");
            unitOfWork.orderDetails.delete(orderDetailsId);
            unitOfWork.Save();
        }

        public IEnumerable<OrderDetails> getByIdOrder(int orderId)
        {
            return unitOfWork.orderDetails.getByIdOrder(orderId);
        }

        public OrderDetails getByOrderDetailsId(int orderDetailsId)
        {
            return unitOfWork.orderDetails.getByOrderDetailsId(orderDetailsId);
        }

        public void add(OrderDetails orderDetails)
        {
            if (orderDetails != null)
            {
                throw new ArgumentException("Invalid order details");
            }
            unitOfWork.orderDetails.add(orderDetails);
            unitOfWork.Save();
        }

        public void update(int orderDetailsId, int count, int discount)
        {
            if (orderDetailsId < 0)
                throw new ArgumentException("Invalid order details id");
            if (count < 0)
                throw new ArgumentException("Invalid count");
            if (discount < 0)
                throw new ArgumentException("Invalid discount");
            unitOfWork.orderDetails.update(orderDetailsId, count, discount);
            unitOfWork.Save();
        }
    }
}
