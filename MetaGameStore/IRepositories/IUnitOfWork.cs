using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepositories
{
    public interface IUnitOfWork
    {
        public IOrderDetailsRepository orderDetails { get; }
        public IOrderRepository order{ get;}
        public IPaymentRepository payment{ get; }
        public IProductGameRepository productGame { get;}
        public IProductRepository product { get;}
        public IUserRepository user{ get;}

        public Task<int> SaveAsync();
        public int Save();
    }
}
