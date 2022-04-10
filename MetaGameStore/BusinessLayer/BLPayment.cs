using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBusinessLayer;
using Enums;
using Models;
using Repositories;

namespace BusinessLayer
{
    public class BLPayment : IPayment
    {
        private readonly UnitOfWork unitOfWork;
        public BLPayment(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public Payment getPaymentById(int paymentId)
        {
            if (paymentId < 0)
                throw new ArgumentException("Invalid payment id");
            return unitOfWork.payment.getPaymentById(paymentId);

        }

        public bool post(Payment payment)
        {
            if (payment != null)
                throw new ArgumentException("Invalid payment");

            unitOfWork.payment.post(payment);
            unitOfWork.Save();
            return true;
        }

        public bool put(int paymentId, PaymentType paymentType)
        {
            if (paymentId < 0)
                throw new ArgumentException("Invalid payment id");
            if ((int)paymentType >= 0 || (int)paymentType < 4)
                throw new ArgumentException("Invalid payment type");

            unitOfWork.payment.put(paymentId, paymentType);
            unitOfWork.Save();
            return true;
        }
    }
}
