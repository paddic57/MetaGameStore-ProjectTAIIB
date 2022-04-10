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
        public void add(Payment payment);
        public void update(int paymentId, PaymentType paymentType);
        public Payment getPaymentById(int paymentId);
    }
}
