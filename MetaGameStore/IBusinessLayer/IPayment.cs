using Enums;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBusinessLayer
{
    public interface IPayment
    {
        public void add(Payment payment);
        public void update(int paymentId, PaymentType paymentType);
        public Payment getPaymentById(int paymentId);
        public IEnumerable<Payment> getPayments();
    }
}
