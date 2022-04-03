using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepositories
{
    public interface IUnitOfWork
    {
        public IOrderDetailsRepository orderDetailsRepository { get; }
        public IOrderRepository orderRepository { get;}
        public IPaymentRepository paymentRepository { get; }
        public IProductGameRepository productGameRepository { get;}
        public IProductRepository productRepository { get;}
        public IUserRepository userRepository { get;}

        void Save();
    }
}
