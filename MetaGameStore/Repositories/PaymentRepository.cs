using IRepositories;
using Models;
using Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly MyContext context;

        public PaymentRepository(MyContext context)
        {
            this.context = context;
        }

        public void add(Payment payment)
        {
            this.context.Add(payment);
        }

        public void update(int paymentId, PaymentType paymentType)
        {
            Payment p = getPaymentById(paymentId);
            if(p != null)
            {
                p.paymentType = (int)paymentType;
            }
        }
        public Payment getPaymentById(int paymentId)
        {
            return this.context.Payments.Where(x => x.id == paymentId).Single();
        }

    }
}
