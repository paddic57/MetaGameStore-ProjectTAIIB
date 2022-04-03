using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepositories
{
    public interface IUnitOfWork
    {
        public IOrderDetailsRepository orderDetailsRepository { get; set; }
        public IOrderRepository orderRepository { get; set; }
        public IPaymentRepository paymentRepository { get; set; }
        public IProductGameRepository productGameRepository { get; set; }
        public IProductRepository productRepository { get; set; }
        public IUserRepository userRepository { get; set; }

        void Save();
    }
}
