using IRepositories;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyContext context;


        public UnitOfWork(MyContext context)
        {
            this.context = context;
        }

        public IOrderDetailsRepository orderDetailsRepository { get; }
        public IOrderRepository orderRepository { get; }
        public IPaymentRepository paymentRepository { get; }
        public IProductGameRepository productGameRepository { get; }
        public IProductRepository productRepository { get; }
        public IUserRepository userRepository { get; }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
