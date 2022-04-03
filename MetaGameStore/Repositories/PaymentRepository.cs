﻿using IRepositories;
using Models.Enums;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly UnitOfWork unitOfWork;

        public PaymentRepository(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void post(Payment payment)
        {
            throw new NotImplementedException();
        }

        public void put(int paymentId, PaymentType paymentType)
        {
            throw new NotImplementedException();
        }
    }
}
