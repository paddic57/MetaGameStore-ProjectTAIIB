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

        public IOrderDetailsRepository _orderDetails;
        public IOrderRepository _order;
        public IPaymentRepository _payment;
        public IProductGameRepository _productGame;
        public IProductRepository _product;
        public IUserRepository _user;

        public IOrderRepository order
        {
            get
            {
                if (this._order == null)
                {
                    this._order = new OrderRepository(context);
                }
                return this._order;
            }
        }
        public IPaymentRepository payment
        {
            get
            {
                if (this._payment == null)
                {
                    this._payment = new PaymentRepository(context);
                }
                return this._payment;
            }
        }
        public IProductGameRepository productGame
        {
            get
            {
                if (this._productGame == null)
                {
                    this._productGame = new ProductGameRepository(context);
                }
                return this._productGame;
            }
        }
        public IProductRepository product
        {
            get
            {
                if (this._product == null)
                {
                    this._product = new ProductRepository(context);
                }
                return this._product;
            }
        }
        public IUserRepository user
        {
            get
            {
                if (this._user == null)
                {
                    this._user = new UserRepository(context);
                }
                return this._user;
            }
        }
        public IOrderDetailsRepository orderDetails
        {
            get
            {
                if (this._orderDetails == null)
                {
                    this._orderDetails = new OrderDetailsRepository(context);
                }
                return this._orderDetails;
            }
        }

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
