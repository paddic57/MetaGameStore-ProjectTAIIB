using IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class UnitOfWorkTests : IUnitOfWork
    {
        public IOrderDetailsRepository orderDetails { get; set; }

        public IOrderRepository order { get; set; }

        public IPaymentRepository payment { get; set; }

        public IProductGameRepository productGame { get; set; }

        public IProductRepository product { get; set; }

        public IUserRepository user { get; set; }

        public int Save()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
