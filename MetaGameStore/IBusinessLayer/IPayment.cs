using Models.Enums;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBusinessLayer
{
    public interface IPayment
    {
        public bool post(Payment payment);
        public bool put(int paymentId, PaymentType paymentType);
    }
}
