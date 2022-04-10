using Enums;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepositories
{
    public interface IPaymentRepository
    {
        public void post(Payment payment);
        public void put(int paymentId, PaymentType paymentType);
        public Payment getPaymentById(int paymentId);
    }
}
