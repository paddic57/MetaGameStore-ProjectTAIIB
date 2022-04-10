using Enums;
using IRepositories;
using Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockRepository
{
    public class MockPaymentRepository: Mock<IPaymentRepository>
    {
        public MockPaymentRepository mockPost()
        {
            Setup(x => x.post(It.IsAny<Payment>()));
            return this;
        }
        public MockPaymentRepository mockPut()
        {
            Setup(x => x.put(It.IsAny<int>(), It.IsAny<PaymentType>()));
            return this;
                
        }
        public MockPaymentRepository mockGetPaymentById(Payment result)
        {
            Setup(x => x.getPaymentById(It.IsAny<int>()))
                .Returns(result);
            return this;
        }
    }
}
