using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBusinessLayer;
using Models.Enums;
using Models.Models;
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
        public bool post(Payment payment)
        {
            throw new NotImplementedException();
        }

        public bool put(int paymentId, PaymentType paymentType)
        {
            throw new NotImplementedException();
        }
    }
}
