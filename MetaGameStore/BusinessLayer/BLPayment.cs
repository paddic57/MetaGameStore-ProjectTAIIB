using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBusinessLayer;
using Enums;
using Models;
using Repositories;
using IRepositories;

namespace BusinessLayer
{
    public class BLPayment : IPayment
    {
        private readonly IUnitOfWork unitOfWork;
        public BLPayment(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public Payment getPaymentById(int paymentId)
        {
            if (paymentId < 0)
                throw new ArgumentException("Invalid payment id");
            return unitOfWork.payment.getPaymentById(paymentId);

        }

        public void add(Payment payment)
        {
            if (payment != null)
                throw new ArgumentException("Invalid payment");

            unitOfWork.payment.add(payment);
            unitOfWork.Save();
        }

        public void update(int paymentId, PaymentType paymentType)
        {
            if (paymentId < 0)
                throw new ArgumentException("Invalid payment id");
            if ((int)paymentType >= 0 || (int)paymentType < 4)
                throw new ArgumentException("Invalid payment type");

            unitOfWork.payment.update(paymentId, paymentType);
            unitOfWork.Save();
        }

        public IEnumerable<Payment> getPayments()
        {
            return unitOfWork.payment.getPayments();
        }
    }
}
