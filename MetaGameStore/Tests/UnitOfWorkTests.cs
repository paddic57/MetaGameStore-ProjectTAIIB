using IRepositories;
using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public  class UnitOfWorkTests
    {
        private readonly MyContext context;


        public UnitOfWorkTests(MyContext context)
        {
            this.context = context;
        }

        public IOrderDetailsRepository orderDetails { get; set; }
        public IOrderRepository order { get; set; }
        public IPaymentRepository payment { get; set; }
        public IProductGameRepository productGame { get; set; }
        public IProductRepository product { get; set; }
        public IUserRepository user { get; set; }

        public async Task<int> SaveAsync()
        {
            return await context.SaveChangesAsync();
        }
        public int Save()
        {
            return context.SaveChanges();
        }
    }
}

