using Models.Enums;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepositories
{
    public interface IPaymentRepository
    {
        //post
        public void post(Payment payment);
        //put-status
        public void put(int paymentId, PaymentType paymentType);
        public Payment getPaymentById(int paymentId);
    }
}
